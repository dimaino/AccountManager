using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AccountManagerAPI;
using AccountManagerAPI.Models;

namespace AccountManagerAPI 
{
    	public static class ModelBuilderExtensions 
        {
		public static void SeedGeneralData(this ModelBuilder ModelBuilder) 
        {
			// Platform
			ModelBuilder.Entity<Platform>().HasData(
			new Platform() 
            {
				PlatformId = 1,
				Name = "Steam",
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Steam Installation and Setup - BKM.docx",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 2,
				Name = "Microsoft Store",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 3,
				Name = "Android",
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Android/Android Game Installation Guide BKM.docx",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 4,
				Name = "Steam VR",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 5,
				Name = "Oculus",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 6,
				Name = "Origin",
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/Game Client Installation and Usage Guide - Origin Software.docx",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 7,
				Name = "Uplay",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 8,
				Name = "Epic",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 9,
				Name = "Standalone",
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 10,
				Name = "BattleNet",
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Battle Net Client - BKM.docx",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 11,
				Name = "Intel Appup",
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Install and Use Guide - Intel AppUp.docx",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Platform() 
            {
				PlatformId = 12,
				Name = "Lego Mini Online",
				URLToDocumentation = "",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			});

			// Event
			ModelBuilder.Entity<Event>().HasData(
			new Event() 
            {
				EventId = 1,
				Name = "IEM",
				Location = "Chicago",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Event() 
            {
				EventId = 2,
				Name = "IEM",
				Location = "Austraila",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Event() 
            {
				EventId = 3,
				Name = "IEM",
				Location = "China",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			},
			new Event() 
            {
				EventId = 4,
				Name = "IEM",
				Location = "Poland",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			});

			// Game
			ModelBuilder.Entity<Game>().HasData(
			// Steam - 1
			new Game() 
            {
				GameId = 1,
				Name = "Virtua Tennis 4",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 4, 29),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 2,
				Name = "Portal 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 4, 19),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 3,
				Name = "Rage",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 11, 18),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 4,
				Name = "F1 Racing 2011",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 23),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 5,
				Name = "Shogun 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 3, 15),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 6,
				Name = "Operation Flashpoint Red River",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 4, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 7,
				Name = "Batman Arkham City",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 10, 18),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 8,
				Name = "Modern Warfare 3",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 11, 8),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 9,
				Name = "Skyrim",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 11, 11),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 10,
				Name = "Renegade Ops",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 13),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 11,
				Name = "Defense Grid",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2008, 12, 8),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 12,
				Name = "Limbo",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 7, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 13,
				Name = "Call of Duty: Black Ops 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 11, 13),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 14,
				Name = "Dishonored",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 10, 9),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 15,
				Name = "Deep Black: Reloaded",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 4, 18),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 16,
				Name = "Civilization 5",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 10, 9),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 17,
				Name = "Command & Conquer 4: Tiberian Twilight",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 3, 16),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 18,
				Name = "Lego: The Lord of the Rings",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 10, 30),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 19,
				Name = "Transformers: Fal of Cybertron",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 8, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 20,
				Name = "Grid 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 8, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 21,
				Name = "Sega and Sonic All Stars Transformed",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 11, 16),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 22,
				Name = "Sega and Sonic All Stars Transformed",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 11, 16),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 23,
				Name = "Civilization 5: Brave New World",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 7, 9),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 24,
				Name = "ARMA 3",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 9, 12),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 25,
				Name = "Broken Age",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 1, 14),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 26,
				Name = "Shadowrun Returns",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 7, 25),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 27,
				Name = "Shadowrun: Dragonfall",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 2, 27),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 28,
				Name = "Trine 2 Complete",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 12, 7),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 29,
				Name = "Grid Autosport",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 6, 24),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 30,
				Name = "Beatbuddy: Tale of the Guardians",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 8, 6),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Beatbuddy",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 31,
				Name = "Transistor",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 5, 20),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Transistor",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 32,
				Name = "Borderlands: The Pre-Sequel Preorder",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 10, 14),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Borderlands,The Pre Sequel",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 33,
				Name = "Alien Isolation",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 10, 7),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Alien Isolation",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 34,
				Name = "Counter Strike: Global Offensive",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 8, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Counter Strike - Global Offensive",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 35,
				Name = "Lara Croft Temple of Osiris",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 12, 9),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Lara Croft and the Temple of Osiris",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 36,
				Name = "Tomb Raider (2013)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 3, 5),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Tomb Raider",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 37,
				Name = "F1 2015",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 7, 10),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 38,
				Name = "Homeworld Remastered Collection",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 2, 25),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 39,
				Name = "Euro Truck Simulator 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 10, 19),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Euro Truck Simulator 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 40,
				Name = "Project Cars",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 5, 6),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Project CARS",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 41,
				Name = "Just Cause 3",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 12, 1),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Just Cause 3",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 42,
				Name = "NBA2K16",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 9, 29),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/NBA2K16",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 43,
				Name = "Rocket League",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 7, 7),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Rocket League",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 44,
				Name = "Warhammer Vermintide - CHECK",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 10, 23),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Warhammer - End Times - Vermintide",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 45,
				Name = "Tom Clancy's Rainbow Six Siege",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 12, 1),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Rainbow6Siege",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 46,
				Name = "Grey Goo",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 1, 23),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Grey Goo",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 47,
				Name = "PES 2017",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 9, 13),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/PES 2017",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 48,
				Name = "Project Cars 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 9, 22),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Project Cars 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 49,
				Name = "PUBG",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 12, 20),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/PUBG",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 50,
				Name = "Total War: Warhammer 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 9, 28),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Total War - Warhammer II",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 51,
				Name = "Lego Marvel Super Heroes 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 8, 2),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Lego - Marvel Super Heroes 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 52,
				Name = "Call of Duty World War II",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 11, 3),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Call of Duty - WWII",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 53,
				Name = "Warhammer: Vermintide 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 3, 8),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Warhammer- Vermintide 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 54,
				Name = "Cuphead",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 9, 29),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Cuphead",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 55,
				Name = "Yooka Laylee",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 4, 11),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Yooka Laylee",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 56,
				Name = "NBA 2K18",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 9, 19),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/NBA 2K18",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 57,
				Name = "SINNER: Sacrifice for Redemption",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 10, 22),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/SINNER Sacrifice for Redemption",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 58,
				Name = "NBA 2k19",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 9, 11),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 59,
				Name = "Hitman 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 11, 13),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Hitman 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 60,
				Name = "Just Cause 4",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 12, 4),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Just Cause 4",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 61,
				Name = "Ring of Elysium",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 9, 19),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Ring of Elysium",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 62,
				Name = "Street Fighter 5",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 2, 16),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Street Fighter V",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 63,
				Name = "Resident Evil 2 Remake",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 1, 25),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Resident Evil 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 64,
				Name = "Outward",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 3, 26),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Outward",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game()
            {
				GameId = 65,
				Name = "Tekken 7",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 3, 18),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Tekken 7",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game(){
				GameId = 66,
				Name = "Soul Calibur 6",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 10, 19),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/SOULCALIBUR VI",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 67,
				Name = "Dragon Ball FighterZ",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 1, 26),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Dragon Ball FighterZ",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 68,
				Name = "DOTA 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 7, 9),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/DOTA 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game() 
            {
				GameId = 69,
				Name = "Ace Combat 7: Skies Unknown",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 1, 18),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/Ace Combat 7 - Skies Unknown",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},
			new Game()
            {
				GameId = 70,
				Name = "Sekiro: Shadows Die Twice",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 3, 22),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 1
			},

			// Microsftstore - 2
			new Game() 
            {
				GameId = 71,
				Name = "Superhot VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 5),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/SUPERHOT",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 2
			},
			new Game() 
            {
				GameId = 72,
				Name = "Gears of War 4",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 10, 11),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Windows Store/Gears of War 4",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 2
			},
			new Game() 
            {
				GameId = 73,
				Name = "Ghostbusters VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 10, 12),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 2
			},
			new Game() 
            {
				GameId = 74,
				Name = "Arizona Sunshine",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 6),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 2
			},
			new Game() 
            {
				GameId = 75,
				Name = "Halo Wars",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 2, 26),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 2
			},

			// Android - 3
			new Game() 
            {
				GameId = 76,
				Name = "Marvel Run Jump Smash",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 1, 30),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 77,
				Name = "Angry Birds (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2009, 10, 19),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Angry Birds",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 78,
				Name = "Angry Birds Space (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 3, 22),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 79,
				Name = "Candy Crush Saga (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 4, 12),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 80,
				Name = "Fruit Ninja (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 4, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Fruit Ninja HD",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 81,
				Name = "Jetpack Joyride (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 82,
				Name = "Plants vs Zombies 2 (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 83,
				Name = "Tap the Frog (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 2, 12),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 84,
				Name = "Tiny Dice Dungeon",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 11, 11),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 85,
				Name = "Fractal Combat X (FCX) (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 1, 8),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 86,
				Name = "GT Racing 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 11, 13),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Windows Store/GT Racing 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 87,
				Name = "Shadowrun Returns",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 7, 25),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 88,
				Name = "Hitman GO",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 4, 17),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Android/Hitman Go",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 89,
				Name = "Sonic Dash",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 3, 7),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Android/Sonic Dash",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 90,
				Name = "Blitz Brigade (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 5, 9),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 91,
				Name = "Assassin's Creed Pirates (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 12, 4),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 92,
				Name = "Jetpack Joyride",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 1),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Windows Store/Jetpack Joyride",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},
			new Game() 
            {
				GameId = 93,
				Name = "Yo-kai Watch Wibble Wobble (Free)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 10, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 3
			},

			// Steam VR - 4
			new Game()
            {
				GameId = 94,
				Name = "The Gallery - Episode 1: Call of the Starseed",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 95,
				Name = "Arizona Sunshine",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 6),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 96,
				Name = "Budget Cuts",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 6, 14),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 97,
				Name = "The LAB",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 98,
				Name = "Raw Data",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 10, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 99,
				Name = "Raw Data (Demo)",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 10, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 100,
				Name = "theBlu",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 101,
				Name = "Tilt Brush",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 102,
				Name = "A-10 VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 103,
				Name = "Job Simulator",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 104,
				Name = "Fantastic Contraption",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 105,
				Name = "Balloon Chair Death Match",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 7, 13),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 106,
				Name = "Serious Sam VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 3, 30),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 107,
				Name = "Warhammer: End Times - Vermintide - CHECK",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 10, 23),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 108,
				Name = "Blue Effect VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 9, 29),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 109,
				Name = "Bullet Sorrow VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 4, 17),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 110,
				Name = "Fruit Ninja VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 7, 7),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Fruit Ninja HD",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 111,
				Name = "NBA 2KVR Experience",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 11, 21),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 112,
				Name = "SportsBar VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 6, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 113,
				Name = "Evasion",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 10, 9),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 114,
				Name = "Sprint Vector",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 2, 8),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 115,
				Name = "Mortal Blitz",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 7, 19),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 116,
				Name = "Onward",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 8, 29),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 117,
				Name = "Space Pirate Trainer",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 4, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 118,
				Name = "Archangel: Hellfire",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 8, 2),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 119,
				Name = "Beatsaber",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 5, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 120,
				Name = "The Gold Club VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 9, 25),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
			new Game() 
            {
				GameId = 121,
				Name = "Creed - Rise to Glory",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 9, 25),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},
            new Game() 
            { 
                GameId = 122, 
                Name = "Creed - Rise to Glory \"Arcade\"", 
                ConnectionType = 2, 
                ReleaseDate = new DateTime(2018, 9, 25), 
                URLToDocumentation = null, 
                CreatedAt = DateTime.Now, 
                UpdatedAt = DateTime.Now, 
                PlatformId = 4 
            },
			new Game() 
            {
				GameId = 123,
				Name = "Audica",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2019, 3, 7),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 4
			},

			// Oculus - 5
			new Game() 
            {
				GameId = 124,
				Name = "Superhot VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 5),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Steam Client Games/SUPERHOT",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 125,
				Name = "Rock Band VR",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 3, 20),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 126,
				Name = "Robo Recall",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 3, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 127,
				Name = "Unspoken",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 128,
				Name = "Dead and Buried",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 12, 5),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 129,
				Name = "Sprint Vector",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 2, 8),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 130,
				Name = "Lone Echo",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 7, 20),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 131,
				Name = "Luna",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 10, 17),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},
			new Game() 
            {
				GameId = 132,
				Name = "Echo Arena",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 7, 20),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 5
			},

			// Origin - 6
			new Game() 
            {
				GameId = 133,
				Name = "Battlefield 3",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 10, 25),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/Battlefield 3",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 134,
				Name = "Fifa Soccer 12",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 27),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/FIFA Soccer 12",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 135,
				Name = "Fifa Soccer 13",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 9, 25),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/FIFA Soccer 13",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 136,
				Name = "Fifa Soccer 14",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 9, 23),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/FIFA Soccer 14",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 137,
				Name = "Titanfall",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 3, 11),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/Titanfall",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 138,
				Name = "Fifa Soccer 15",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 9, 23),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/FIFA Soccer 15",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 139,
				Name = "The SIMS 4",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 9, 2),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/The SIMS 4",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game()
            {
				GameId = 140,
				Name = "Titanfall 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 10, 28),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/Titanfall 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},
			new Game() 
            {
				GameId = 141,
				Name = "Battlefield 1",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 10, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Origin Client Games/Battlefield 1",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 6
			},

			// Uplay - 7
			new Game() 
            {
				GameId = 142,
				Name = "Tom Clany's Raimbow Six Siege",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 12, 1),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 7
			},
			new Game() 
            {
				GameId = 143,
				Name = "Assassin's Creed Origins",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 10, 27),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Assassin's Creed - Origins",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 7
			},

			// Epic - 8
			new Game() 
            {
				GameId = 144,
				Name = "Fortnite",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2017, 7, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Fortnite",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 8
			},
			new Game() 
            {
				GameId = 145,
				Name = "Unreal Tournament",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1999, 11, 30),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 8
			},

			// Standalone - 9
			new Game() 
            {
				GameId = 146,
				Name = "Lost Planet 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 4, 28),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Lost Planet2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 147,
				Name = "DnD Daggerdale",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 6, 24),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/DnD Daggerdale",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 148,
				Name = "Need For Speed World",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 7, 20),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 149,
				Name = "DarkSpore",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 4, 26),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Darkspore",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 150,
				Name = "Might & Magic Heroes VI",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 10, 13),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/Might and Magic Heroes VI",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},

			new Game() 
            {
				GameId = 151,
				Name = "LEGO Mini Figures Online",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 10, 29),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Independent/LEGO Minifigures Online",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},

			new Game() 
            {
				GameId = 152,
				Name = "TrackMania 2 - Canyon",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 14),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/ManiaPlanet/TrackMania 2 - Canyon",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 153,
				Name = "ShootMania",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 4, 10),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/ManiaPlanet/ShootMania Storm",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 154,
				Name = "Trackmania - Valley",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 7, 4),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/ManiaPlanet/Trackmania 2 - Valley",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},
			new Game() 
            {
				GameId = 155,
				Name = "Trackmania - Stadium",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 9, 14),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/ManiaPlanet/Trackmania 2 - Stadium",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},

			new Game() 
            {
				GameId = 156,
				Name = "Star Trek Online",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 2, 2),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			},

			// Playstation - 10
			new Game() 
            {
				GameId = 157,
				Name = "Planetside 2",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 11, 20),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Sony Station/Planetside 2",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 10
			},
			new Game() 
            {
				GameId = 158,
				Name = "Dragons Prophet",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 9, 18),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Sony Station/Dragons Prophet",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 10
			},

			// Battlenet - 11
			new Game() 
            {
				GameId = 159,
				Name = "Call of Duty: BO4",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2018, 10, 12),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Call of Duty Black Ops 4",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 160,
				Name = "World of Warcraft",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2004, 11, 23),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 161,
				Name = "Starcraft 2: Wings of Liberty",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 7, 27),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Starcraft II",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 162,
				Name = "Starcraft 2: Heart of the Swarm",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2013, 3, 12),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Starcraft II",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 163,
				Name = "Starcraft 2: Legacy of the Void",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 11, 10),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Starcraft II",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 164,
				Name = "Starcraft 2: Nova Convert Ops",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 3, 29),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Starcraft II",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 165,
				Name = "Hearthstone",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2014, 3, 11),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Hearthstone",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 166,
				Name = "Overwatch",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2016, 5, 24),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Overwatch",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 167,
				Name = "Heroes of the Storm",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2015, 6, 2),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Battlenet/Heroes of the Storm",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
			new Game() 
            {
				GameId = 168,
				Name = "Starcraft",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1998, 3, 31),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 11
			},
            new Game() 
            {
				GameId = 169,
				Name = "Angry Birds",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2009, 12, 11),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Angry Birds",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 170,
				Name = "Top Shot",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 3, 12),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Top Shot",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 171,
				Name = "Angry Birds Rio",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 3, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Angry Birds Rio",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 172,
				Name = "Fruit Ninja",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2010, 4, 21),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Fruit Ninja HD",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 173,
				Name = "Pac-Man",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1980, 5, 22),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/Pac-Man",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 174,
				Name = "Dr. Robotnik's Mean Bean Machine",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1993, 11, 26),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/SEGA Classics - Dr Robotniks MBM",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 175,
				Name = "Sonic 3D Blast",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1996, 11, 1),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/SEGA Classics - Sonic 3D Blast",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 176,
				Name = "Sonic the Hedgehog Spinball",
				ConnectionType = 2,
				ReleaseDate = new DateTime(1993, 11, 15),
				URLToDocumentation = "http://ddc.intel.com/Production/loancenter/DDLC Prep Documents/Games and Entertainment/Video Games/Intel AppUp/SEGA Classics - Sonic Spinball",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 177,
				Name = "Sonic & All-Stars Racing Transformed",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2012, 11, 16),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 12
			},
            new Game() 
            {
				GameId = 178,
<<<<<<< HEAD
				Name = "Battlefield Play4Free",
				ConnectionType = 2,
				ReleaseDate = new DateTime(2011, 4, 4),
				URLToDocumentation = null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				PlatformId = 9
			});
		}
	}
}