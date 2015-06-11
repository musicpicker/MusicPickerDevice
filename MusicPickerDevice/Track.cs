﻿using LiteDB;
using Newtonsoft.Json;

namespace MusicPickerDevice
{
    public class Track
    {
        [JsonConverter(typeof(ToStringJsonConverter))]
        public ObjectId Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public uint Year { get; set; }
        public uint Number { get; set; }
        public uint Count { get; set; }
        [BsonIndex]
        public string Path { get; set; }
    }
}