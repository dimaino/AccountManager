using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace AccountManagerAPI.Models
{
	public class Code
    {
        [Key]
        public int CodeId {get;set;}
        [Required]
        public string CodeString {get;set;}
        [Required]
        public bool UsedStatus {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Account Account {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int GameId {get;set;}
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Game Game {get;set;}
    }
}