using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    [JsonConverter(typeof(ChannelConverter))]
    public abstract class Channel
    {
        /// <summary>
        /// Type of the channel
        /// </summary>
        [JsonProperty("channel_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChannelType? Type { get; set; }

        /// <summary>
        /// Unique ID of the channel
        /// </summary>
        [JsonProperty("_id")]
        public ID? ChannelID { get; set; }
    }

    public class ChannelConverter : JsonConverter<Channel>
    {
        public override Channel? ReadJson(JsonReader reader, Type objectType, Channel? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jo = JObject.Load(reader);
            var type = jo["channel_type"]?.Value<ChannelType>();
            Channel target;

            switch (type)
            {
                case ChannelType.SavedMessages:
                    target = new SavedMessagesChannel();
                    break;
                case ChannelType.DirectMessage:
                    target = new DirectMessageChannel();
                    break;
                case ChannelType.Group:
                    target = new GroupChannel();
                    break;
                case ChannelType.TextChannel:
                    target = new TextChannel();
                    break;
                case ChannelType.VoiceChannel:
                    target = new VoiceChannel();
                    break;
                default:
                    throw new NotSupportedException($"Channel type '{type.ToString} is not supported'");
            }

            serializer.Populate(jo.CreateReader(), target);
            return target;
        }

        public override void WriteJson(JsonWriter writer, Channel? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
