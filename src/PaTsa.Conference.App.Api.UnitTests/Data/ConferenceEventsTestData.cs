using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using PaTsa.Conference.App.Api.WebApi.Entities;

// ReSharper disable StringLiteralTypo

namespace PaTsa.Conference.App.Api.UnitTests.Data;

[ExcludeFromCodeCoverage]
public class ConferenceEventsTestData : IEnumerable<object[]>
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000001",
                Location = "Online Sign Up",
                Name = "Animatronics",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000002",
                Location = "Winterberry",
                Name = "Architectural Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000003",
                Location = "Winterberry",
                Name = "Biotechnology Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000004",
                Location = "Winterberry",
                Name = "Board Game Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000005",
                Location = "Winterberry",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000006",
                Location = "Sunburst",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000007",
                Location = "Winterberry",
                Name = "Engineering Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000008",
                Location = "Winterberry",
                Name = "Fashion Design and Technology",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000009",
                Location = "Sunburst",
                Name = "Forensic Science",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000A",
                Location = "Winterberry",
                Name = "Geospatial Technology",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000B",
                Location = "Winterberry",
                Name = "Manufacturing Prototype",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000C",
                Location = "Winterberry",
                Name = "PA - Electronic Research & Exp",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000D",
                Location = "Winterberry",
                Name = "PA - Logo Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000E",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "00000000000000000000000F",
                Location = "Winterberry",
                Name = "Promotional Design",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000010",
                Location = "Sunburst",
                Name = "Technology Bowl",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000011",
                Location = "Winterberry",
                Name = "Transportation Modeling",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 18:30"),
                Id = "000000000000000000000012",
                Location = "Winterberry",
                Name = "Virtual Reality Visualization (VR)",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000013",
                Location = "Sunburst",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000014",
                Location = "Sunburst",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000015",
                Location = "Sunburst",
                Name = "Cybersecurity",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000016",
                Location = "Sunburst",
                Name = "Electrical Applications",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000017",
                Location = "Sunburst",
                Name = "Forensic Technology",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000018",
                Location = "Sunburst",
                Name = "Foundations of Information Technology",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/19/2023 21:00"),
                Id = "000000000000000000000019",
                Location = "Sunburst",
                Name = "Tech Bowl",
                StartDateTime = DateTime.Parse("4/19/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000001A",
                Location = "Online Sign Up",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 19:00"),
                Id = "00000000000000000000001B",
                Location = "Grand Ballroom",
                Name = "Dragster Design",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000001C",
                Location = "Online Sign Up",
                Name = "Extemporaneous Presentation",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000001D",
                Location = "Online Sign Up",
                Name = "Prepared Presentation",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000001E",
                Location = "Online Sign Up",
                Name = "Software Development",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000001F",
                Location = "Online Sign Up",
                Name = "Challenging Technology Issues",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000020",
                Location = "Online Sign Up",
                Name = "Leadership Strategies",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000021",
                Location = "Online Sign Up",
                Name = "Prepared Speech",
                StartDateTime = DateTime.Parse("4/19/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000022",
                Location = "Winterberry",
                Name = "Biotechnology",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000023",
                Location = "Winterberry",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000024",
                Location = "Winterberry",
                Name = "Construction Challenge",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000025",
                Location = "Winterberry",
                Name = "Data Science and Analytics",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000026",
                Location = "Winterberry",
                Name = "Inventions and Innovations",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000027",
                Location = "Winterberry",
                Name = "Mass Production",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000028",
                Location = "Winterberry",
                Name = "Medical Technology",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "000000000000000000000029",
                Location = "Winterberry",
                Name = "Microcontroller Design",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002A",
                Location = "Winterberry",
                Name = "Off the Grid",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002B",
                Location = "Winterberry",
                Name = "PA - Logo Design",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002C",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/19/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002D",
                Location = "Grand Ballroom",
                Name = "Drone Challenge (UAV)",
                StartDateTime = DateTime.Parse("4/19/2023 19:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002E",
                Location = "Grand Ballroom",
                Name = "Dragster",
                StartDateTime = DateTime.Parse("4/19/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Are you in the choir at school? Do you just sing in the shower? No matter how awful your singing is, come to the Karaoke Night special interest session where you can relieve some stress and sing along to your favorite tunes. Get the chance to compete with your friends and other students. The person with the best performance will be honored with a prize.",
                EndDateTime = DateTime.Parse("4/19/2023 20:00"),
                Id = "00000000000000000000002F",
                Location = "Exhibit Hall",
                Name = "Karaoke Night",
                StartDateTime = DateTime.Parse("4/19/2023 19:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Directions",
                EndDateTime = DateTime.Parse("4/19/2023 20:15"),
                Id = "000000000000000000000030",
                Location = "Fox Den",
                Name = "On Demand Video",
                StartDateTime = DateTime.Parse("4/19/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/19/2023 20:30"),
                Id = "000000000000000000000031",
                Location = "Ski Lodge",
                Name = "Senior Solar Sprint",
                StartDateTime = DateTime.Parse("4/19/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Directions",
                EndDateTime = DateTime.Parse("4/19/2023 20:15"),
                Id = "000000000000000000000032",
                Location = "Laurel",
                Name = "Technical Design",
                StartDateTime = DateTime.Parse("4/19/2023 20:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Directions",
                EndDateTime = DateTime.Parse("4/19/2023 20:30"),
                Id = "000000000000000000000033",
                Location = "Fox Den",
                Name = "PA - Digital Video Challenge",
                StartDateTime = DateTime.Parse("4/19/2023 20:15"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Judging",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "000000000000000000000034",
                Location = "Ski Lodge",
                Name = "Senior Solar Sprint",
                StartDateTime = DateTime.Parse("4/20/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Judging",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "000000000000000000000035",
                Location = "Winterberry",
                Name = "Virtual Reality Visualization (VR)",
                StartDateTime = DateTime.Parse("4/20/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000036",
                Location = "Snowflake",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Races",
                EndDateTime = DateTime.Parse("4/20/2023 17:00"),
                Id = "000000000000000000000037",
                Location = "Grand Ballroom",
                Name = "Dragster Design",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drone Testing",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "000000000000000000000038",
                Location = "Grand Ballroom",
                Name = "Drone Challenge (UAV)",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000039",
                Location = "Snowflake",
                Name = "Forensic Science",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/20/2023 10:30"),
                Id = "00000000000000000000003A",
                Location = "Grand Ballroom",
                Name = "PA - R.C. Off-Road Racing",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 12:30"),
                Id = "00000000000000000000003B",
                Location = "Ski Lodge - 2nd Floor",
                Name = "System Control Technology",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "TESTING",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000003C",
                Location = "Snowflake",
                Name = "Technology Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 11:30"),
                Id = "00000000000000000000003D",
                Location = "Chestnut",
                Name = "Challenging Technology Issues",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/20/2023 11:30"),
                Id = "00000000000000000000003E",
                Location = "Evergreen",
                Name = "Challenging Technology Issues",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000003F",
                Location = "Snowflake",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000040",
                Location = "Snowflake",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000041",
                Location = "Snowflake",
                Name = "Cybersecurity",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Races",
                EndDateTime = DateTime.Parse("4/20/2023 17:00"),
                Id = "000000000000000000000042",
                Location = "Grand Ballroom",
                Name = "Dragster",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000043",
                Location = "Snowflake",
                Name = "Electrical Applications",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000044",
                Location = "Snowflake",
                Name = "Forensic Technology",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "000000000000000000000045",
                Location = "Snowflake",
                Name = "Foundations of Information Technology",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Construction",
                EndDateTime = DateTime.Parse("4/20/2023 12:00"),
                Id = "000000000000000000000046",
                Location = "Ski Lodge",
                Name = "PA - Delta Dart",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/20/2023 10:30"),
                Id = "000000000000000000000047",
                Location = "Grand Ballroom",
                Name = "PA - R/C Off-Road Racing",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 12:30"),
                Id = "000000000000000000000048",
                Location = "Seasons #1",
                Name = "Prepared Speech",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 12:30"),
                Id = "000000000000000000000049",
                Location = "Ski Lodge - 2nd Floor",
                Name = "System Control Technology",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000004A",
                Location = "Snowflake",
                Name = "Tech Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 9:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 12:00"),
                Id = "00000000000000000000004B",
                Location = "Fox Den",
                Name = "Essays on Technology",
                StartDateTime = DateTime.Parse("4/20/2023 10:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000004C",
                Location = "Ski Lodge - Maple",
                Name = "Structural Design & Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 10:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest - Outline",
                EndDateTime = DateTime.Parse("4/20/2023 12:00"),
                Id = "00000000000000000000004D",
                Location = "Fox Den",
                Name = "Essays on Technology",
                StartDateTime = DateTime.Parse("4/20/2023 10:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000004E",
                Location = "Ski Lodge - Maple",
                Name = "Structural Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 10:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Are you getting ready to apply for college in the fall or within the next few years? Have you already applied to college? Everyone is welcome to the college readiness special interest sessions where you can hear directly from college students and professionals who have been involved in TSA. Hear about everything from the application process to practical skills and habits to be successful as you move into your post secondary education.",
                EndDateTime = DateTime.Parse("4/20/2023 11:00"),
                Id = "00000000000000000000004F",
                Location = "Place: Matterhorn Lounge",
                Name = "College Readiness",
                StartDateTime = DateTime.Parse("4/20/2023 10:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Do you like parliamentary procedure? Are you a beginner looking to learn the basics? Come to the Parly Pro interest session! This session is run by the Bylaw and Resolutions Review Committee and will consist of an informational presentation as well as an activity. It will cover both beginner and advanced parliamentary procedure content in one session.",
                EndDateTime = DateTime.Parse("4/20/2023 12:00"),
                Id = "000000000000000000000050",
                Location = "Matterhorn Lounge",
                Name = "Parly Pro (BARRC)",
                StartDateTime = DateTime.Parse("4/20/2023 11:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Interested in learning about other chapters? Have an idea you’d like to bring to the State Officers? If you’re a chapter president, come join us for lunch! Stop by the buffet, grab some food, and look for the reserved table.",
                EndDateTime = DateTime.Parse("4/20/2023 12:30"),
                Id = "000000000000000000000051",
                Location = "Exhibit Hall",
                Name = "Chapter President’s luncheon",
                StartDateTime = DateTime.Parse("4/20/2023 11:30"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Heats",
                EndDateTime = DateTime.Parse("4/20/2023 14:30"),
                Id = "000000000000000000000052",
                Location = "Chestnut/Dogwood",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/20/2023 12:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pro/Con",
                EndDateTime = DateTime.Parse("4/20/2023 14:30"),
                Id = "000000000000000000000053",
                Location = "Chestnut/Dogwood",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/20/2023 12:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Time Trials",
                EndDateTime = DateTime.Parse("4/20/2023 13:30"),
                Id = "000000000000000000000054",
                Location = "Ski Lodge",
                Name = "Senior Solar Sprint",
                StartDateTime = DateTime.Parse("4/20/2023 12:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Trim/Flights - pre-built gliders",
                EndDateTime = DateTime.Parse("4/20/2023 14:30"),
                Id = "000000000000000000000055",
                Location = "Grand Ballroom",
                Name = "Flight",
                StartDateTime = DateTime.Parse("4/20/2023 12:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Are you someone who loves mystery, competition, and some serious fun? Come to the escape room where you’ll have a chance to compete against other teams by solving problems and working together. It’s a great opportunity to put your skills to the test.",
                EndDateTime = DateTime.Parse("4/20/2023 13:00"),
                Id = "000000000000000000000056",
                Location = "Matterhorn Lounge",
                Name = "Escape Room",
                StartDateTime = DateTime.Parse("4/20/2023 12:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 14:30"),
                Id = "000000000000000000000057",
                Location = "Chestnut",
                Name = "Challenging Technology Issues",
                StartDateTime = DateTime.Parse("4/20/2023 12:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000058",
                Location = "Laurel",
                Name = "Leadership Strategies",
                StartDateTime = DateTime.Parse("4/20/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000059",
                Location = "Fox Den",
                Name = "Leadership Strategies",
                StartDateTime = DateTime.Parse("4/20/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "00000000000000000000005A",
                Location = "Seasons #1",
                Name = "Prepared Speech",
                StartDateTime = DateTime.Parse("4/20/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Do you have a competitive streak? Have a need to crush your teammates in monopoly? Swing by the game room! Here you will be able to play against your friends and other TSA members in activities ranging from board games to video games. Good luck!",
                EndDateTime = DateTime.Parse("4/20/2023 14:00"),
                Id = "00000000000000000000005B",
                Location = "Matterhorn Lounge",
                Name = "Game Room",
                StartDateTime = DateTime.Parse("4/20/2023 13:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "00000000000000000000005C",
                Location = "Evergreen",
                Name = "Challenging Technology Issues",
                StartDateTime = DateTime.Parse("4/20/2023 13:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Judging",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "00000000000000000000005D",
                Location = "Grand Ballroom",
                Name = "Drone Challenge (UAV)",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Contest",
                EndDateTime = DateTime.Parse("4/20/2023 17:00"),
                Id = "00000000000000000000005E",
                Location = "Alpine",
                Name = "Promotional Design",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "00000000000000000000005F",
                Location = "Ski Lodge - Maple",
                Name = "Structural Design & Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/20/2023 17:30"),
                Id = "000000000000000000000060",
                Location = "Alpine",
                Name = "Digital Photography",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/20/2023 0:00"),
                Id = "000000000000000000000061",
                Location = "Ski Lodge - Maple",
                Name = "Structural Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Are you looking for some competition with friends? Do you like racing? Make sure to come to the first ever State Conference Mario Kart Tournament! We’ll be hosting a bracket tournament for individuals looking to show off their skills. Make sure to bring your A game…there will be a prize for the winner!",
                EndDateTime = DateTime.Parse("4/20/2023 15:00"),
                Id = "000000000000000000000062",
                Location = "Matterhorn Lounge",
                Name = "Mario Kart Tournament",
                StartDateTime = DateTime.Parse("4/20/2023 14:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Presentations",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000063",
                Location = "Winterberry",
                Name = "Animatronics",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000064",
                Location = "Winterberry",
                Name = "Architectural Design",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000065",
                Location = "Winterberry",
                Name = "Biotechnology Design",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000066",
                Location = "Winterberry",
                Name = "Board Game Design",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000067",
                Location = "Winterberry",
                Name = "Engineering Design",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 17:30"),
                Id = "000000000000000000000068",
                Location = "Grand Ballroom",
                Name = "Flight Endurance",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000069",
                Location = "Winterberry",
                Name = "Geospatial Technology",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "00000000000000000000006A",
                Location = "Winterberry",
                Name = "Manufacturing Prototype",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "00000000000000000000006B",
                Location = "Winterberry",
                Name = "PA - Electronic Research & Exp",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "00000000000000000000006C",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/20/2023 16:30"),
                Id = "00000000000000000000006D",
                Location = "Ski Lodge",
                Name = "Senior Solar Sprint",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "00000000000000000000006E",
                Location = "Ski Lodge - 2nd Floor",
                Name = "System Control Technology",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "00000000000000000000006F",
                Location = "Winterberry",
                Name = "Transportation Modeling",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000070",
                Location = "Winterberry",
                Name = "Virtual Reality Visualization (VR)",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000071",
                Location = "Winterberry",
                Name = "Biotechnology",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000072",
                Location = "Winterberry",
                Name = "Construction Challenge",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000073",
                Location = "Winterberry",
                Name = "Inventions and Innovations",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000074",
                Location = "Winterberry",
                Name = "Mass Production",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000075",
                Location = "Winterberry",
                Name = "Medical Technology",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Presentations",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000076",
                Location = "Winterberry",
                Name = "Microcontroller Design",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000077",
                Location = "Winterberry",
                Name = "Off the Grid",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000078",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "000000000000000000000079",
                Location = "Ski Lodge - 2nd Floor",
                Name = "System Control Technology",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Calling all Tech Bowl enthusiasts- students, advisors, and alumni! The National Service Project Committee is hosting a Student vs. Advisors and Alumni Tech Bowl competition. This fun and informal event is a fundraiser for the American Cancer Society (ACS), so bring a donation for the ACS if you are able! Bring your team of three, or come alone!",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "00000000000000000000007A",
                Location = "Sunburst",
                Name = "Advisor Tech Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Learn how business and STEM intersect through the Future for Her Business Workshop! From brainstorming your unique concepts to creating your very own business plan, this workshop will teach you how to turn your ideas into a reality. Learn business skills and new software, and unleash your entrepreneurial spirit!",
                EndDateTime = DateTime.Parse("4/20/2023 16:00"),
                Id = "00000000000000000000007B",
                Location = "Matterhorn Lounge",
                Name = "Future for Her",
                StartDateTime = DateTime.Parse("4/20/2023 15:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Finals",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "00000000000000000000007C",
                Location = "Evergreen",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "00000000000000000000007D",
                Location = "Chestnut",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "00000000000000000000007E",
                Location = "Chestnut",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 19:00"),
                Id = "00000000000000000000007F",
                Location = "Grand Ballroom",
                Name = "Dragster Design",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/20/2023 19:00"),
                Id = "000000000000000000000080",
                Location = "Grand Ballroom",
                Name = "Dragster",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Want to learn more about the State Officer Candidates? Come to the meet and greet! This is your chance to ask questions, learn more about campaign platforms, and talk one-on-one with each of the candidates.",
                EndDateTime = DateTime.Parse("4/20/2023 17:00"),
                Id = "000000000000000000000081",
                Location = "Matterhorn Lounge",
                Name = "Committee Meet and Greet",
                StartDateTime = DateTime.Parse("4/20/2023 16:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000082",
                Location = "Grand Ballroom",
                Name = "Dragster Design",
                StartDateTime = DateTime.Parse("4/20/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000083",
                Location = "Grand Ballroom",
                Name = "Dragster",
                StartDateTime = DateTime.Parse("4/20/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Learn how business and STEM intersect through the Future for Her Business Workshop! From brainstorming your unique concepts to creating your very own business plan, this workshop will teach you how to turn your ideas into a reality. Learn business skills and new software, and unleash your entrepreneurial spirit!",
                EndDateTime = DateTime.Parse("4/20/2023 18:00"),
                Id = "000000000000000000000084",
                Location = "Matterhorn Lounge",
                Name = "Future for Her",
                StartDateTime = DateTime.Parse("4/20/2023 17:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "000000000000000000000085",
                Location = "Sunburst",
                Name = "Tech Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "000000000000000000000086",
                Location = "Hemlock",
                Name = "Tech Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "000000000000000000000087",
                Location = "Alpine",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/20/2023 18:30"),
                Id = "000000000000000000000088",
                Location = "Grand Ballroom",
                Name = "Flight Endurance",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/20/2023 19:00"),
                Id = "000000000000000000000089",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/20/2023 19:00"),
                Id = "00000000000000000000008A",
                Location = "Timberstone",
                Name = "PA-TSA VEX - HS",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/20/2023 22:00"),
                Id = "00000000000000000000008B",
                Location = "Alpine",
                Name = "Coding",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/20/2023 19:00"),
                Id = "00000000000000000000008C",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Competition",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "00000000000000000000008D",
                Location = "Timberstone",
                Name = "PA-TSA VEX - MS",
                StartDateTime = DateTime.Parse("4/20/2023 18:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/20/2023 21:30"),
                Id = "00000000000000000000008E",
                Location = "Laurel",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/20/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/20/2023 19:30"),
                Id = "00000000000000000000008F",
                Location = "Evergreen",
                Name = "Mechanical Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Sign-up",
                EndDateTime = DateTime.Parse("4/20/2023 19:30"),
                Id = "000000000000000000000090",
                Location = "Evergreen",
                Name = "Mechanical Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 18:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Finals",
                EndDateTime = DateTime.Parse("4/20/2023 19:15"),
                Id = "000000000000000000000091",
                Location = "Exhibit Hall",
                Name = "Fashion Design and Technology",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Track Set-up",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "000000000000000000000092",
                Location = "Grand Ballroom",
                Name = "PA - R.C. Off-Road Racing",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Construction",
                EndDateTime = DateTime.Parse("4/20/2023 21:30"),
                Id = "000000000000000000000093",
                Location = "Ski Lodge - Maple",
                Name = "Structural Design & Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Presentations",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "000000000000000000000094",
                Location = "Seasons #4",
                Name = "Cybersecurity",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/20/2023 20:30"),
                Id = "000000000000000000000095",
                Location = "Seasons #2",
                Name = "Data Science and Analytics",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semifinalist Construction",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "000000000000000000000096",
                Location = "Ski Lodge",
                Name = "Flight",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Track Set-up",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "000000000000000000000097",
                Location = "Grand Ballroom",
                Name = "PA - R/C Off-Road Racing",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Practice",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "000000000000000000000098",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Construction",
                EndDateTime = DateTime.Parse("4/20/2023 21:30"),
                Id = "000000000000000000000099",
                Location = "Ski Lodge - Maple",
                Name = "Structural Engineering",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Want to learn more about the State Officer Candidates? Come to the meet and greet! This is your chance to ask questions, learn more about campaign platforms, and talk one-on-one with each of the candidates.",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "00000000000000000000009A",
                Location = "Place: Hotel Lobby",
                Name = "Candidate Meet and Greet",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Each group in the event will be asked to go on a scavenger hunt to find answers about the Seven Springs Mountain Resort and TSA. Groups can be 1-4 people. Prizes will be awarded to the participants with the highest number of correct answers and the quickest time. Your advisor will be contacted with your prize.",
                EndDateTime = DateTime.Parse("4/20/2023 20:00"),
                Id = "00000000000000000000009B",
                Location = "Matterhorn",
                Name = "Scavenger Hunt – Seven Springs/TSA Trivia",
                StartDateTime = DateTime.Parse("4/20/2023 19:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Finals",
                EndDateTime = DateTime.Parse("4/20/2023 19:45"),
                Id = "00000000000000000000009C",
                Location = "Winterberry",
                Name = "Fashion Design and Technology",
                StartDateTime = DateTime.Parse("4/20/2023 19:15"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Presentations",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "00000000000000000000009D",
                Location = "Seasons #1",
                Name = "Data Science and Analytics",
                StartDateTime = DateTime.Parse("4/20/2023 19:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Trim/Flights",
                EndDateTime = DateTime.Parse("4/20/2023 20:30"),
                Id = "00000000000000000000009E",
                Location = "Grand Ballroom",
                Name = "PA - Delta Dart",
                StartDateTime = DateTime.Parse("4/20/2023 19:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Finals",
                EndDateTime = DateTime.Parse("4/20/2023 21:30"),
                Id = "00000000000000000000009F",
                Location = "Exhibit Hall",
                Name = "Fashion Design and Technology",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/20/2023 20:30"),
                Id = "0000000000000000000000A0",
                Location = "Timberstone",
                Name = "PA-TSA VEX - HS",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Video",
                EndDateTime = DateTime.Parse("4/20/2023 22:30"),
                Id = "0000000000000000000000A1",
                Location = "Sunburst",
                Name = "Technology Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/20/2023 22:30"),
                Id = "0000000000000000000000A2",
                Location = "Hemlock",
                Name = "Technology Bowl",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Check-in",
                EndDateTime = DateTime.Parse("4/20/2023 20:30"),
                Id = "0000000000000000000000A3",
                Location = "Ski Lodge",
                Name = "Junior Solar Sprint",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Come check out the Jeopardy trivia night special interest session! We'll be competing in teams. If you have a team that you want to work with, that's great! But if you don't, we will find you a team! Trivia night will be conducted in a Jeopardy style format. We're excited to see all of you there! This… Is… Jeopardy!",
                EndDateTime = DateTime.Parse("4/20/2023 21:00"),
                Id = "0000000000000000000000A4",
                Location = "Snowflake",
                Name = "Jeopardy Trivia Night – State Officer Team",
                StartDateTime = DateTime.Parse("4/20/2023 20:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Practice",
                EndDateTime = DateTime.Parse("4/20/2023 22:00"),
                Id = "0000000000000000000000A5",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/20/2023 20:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Practice",
                EndDateTime = DateTime.Parse("4/20/2023 22:00"),
                Id = "0000000000000000000000A6",
                Location = "Timberstone",
                Name = "PA-TSA VEX - HS",
                StartDateTime = DateTime.Parse("4/20/2023 20:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Come and listen to the PA TSA State Officer Candidates speeches about why they want to \"Be Your Next State Officer.\" Speeches will be viewed as a group and if time allows, a live Q&A will occur where you can ask the candidates your questions. Two representatives must be present to be able to vote for your chapter.",
                EndDateTime = DateTime.Parse("4/20/2023 23:00"),
                Id = "0000000000000000000000A7",
                Location = "Exhibit Hall",
                Name = "State Officer Candidate Speeches",
                StartDateTime = DateTime.Parse("4/20/2023 21:30"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Come learn more about joining PA-TSA’s active alumni association.",
                EndDateTime = DateTime.Parse("4/20/2023 23:00"),
                Id = "0000000000000000000000A8",
                Location = "Sunburst",
                Name = "Alumni Meeting – open to all graduating seniors and current TSA alumni",
                StartDateTime = DateTime.Parse("4/20/2023 22:30"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/21/2023 7:45"),
                Id = "0000000000000000000000A9",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Architecture",
                StartDateTime = DateTime.Parse("4/21/2023 7:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/21/2023 7:45"),
                Id = "0000000000000000000000AA",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 7:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Set-up",
                EndDateTime = DateTime.Parse("4/21/2023 7:45"),
                Id = "0000000000000000000000AB",
                Location = "Alpine",
                Name = "Computer-Aided Design Foundations",
                StartDateTime = DateTime.Parse("4/21/2023 7:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 11:30"),
                Id = "0000000000000000000000AC",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 11:30"),
                Id = "0000000000000000000000AD",
                Location = "Seasons #2",
                Name = "Extemporaneous Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000AE",
                Location = "Sunburst",
                Name = "Extemporaneous Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Prep",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000AF",
                Location = "Snowflake",
                Name = "Extemporaneous Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Races",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000B0",
                Location = "Grand Ballroom",
                Name = "PA - R.C. Off-Road Racing",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/21/2023 8:30"),
                Id = "0000000000000000000000B1",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/21/2023 8:30"),
                Id = "0000000000000000000000B2",
                Location = "Timberstone",
                Name = "PA-TSA VEX - HS",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 11:30"),
                Id = "0000000000000000000000B3",
                Location = "Seasons #3",
                Name = "Prepared Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000B4",
                Location = "Sunburst",
                Name = "Prepared Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 11:30"),
                Id = "0000000000000000000000B5",
                Location = "Alpine",
                Name = "Computer-Aided Design Foundations",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Races",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000B6",
                Location = "Grand Ballroom",
                Name = "PA - R/C Off-Road Racing",
                StartDateTime = DateTime.Parse("4/21/2023 8:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Entry submission",
                EndDateTime = DateTime.Parse("4/21/2023 9:30"),
                Id = "0000000000000000000000B7",
                Location = "Online Submission",
                Name = "On Demand Video",
                StartDateTime = DateTime.Parse("4/21/2023 8:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 11:00"),
                Id = "0000000000000000000000B8",
                Location = "Exhibit Hall - Annex",
                Name = "Mechanical Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 8:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Entry submission",
                EndDateTime = DateTime.Parse("4/21/2023 9:30"),
                Id = "0000000000000000000000B9",
                Location = "Online Submission",
                Name = "PA - Digital Video Challenge",
                StartDateTime = DateTime.Parse("4/21/2023 8:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Entry submission",
                EndDateTime = DateTime.Parse("4/21/2023 9:30"),
                Id = "0000000000000000000000BA",
                Location = "Online Submission",
                Name = "Technical Design",
                StartDateTime = DateTime.Parse("4/21/2023 8:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Presentation",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000BB",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Audio Podcasting",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000BC",
                Location = "Chestnut",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000BD",
                Location = "Chestnut",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000BE",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Data Science and Analytics",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000BF",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Digital Video Production",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 11:00"),
                Id = "0000000000000000000000C0",
                Location = "Hemlock",
                Name = "Drone Challenge (UAV)",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C1",
                Location = "Fox Den",
                Name = "Future Technology & Engineering Teacher",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C2",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Music Production",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Competition",
                EndDateTime = DateTime.Parse("4/21/2023 10:30"),
                Id = "0000000000000000000000C3",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Presentations",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C4",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Software Development",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C5",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Video Game Design",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C6",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Webmaster",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C7",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Career Prep",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals Contest",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C8",
                Location = "Dogwood",
                Name = "Chapter Team",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000C9",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Community Service Video",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 11:00"),
                Id = "0000000000000000000000CA",
                Location = "Laurel",
                Name = "Promotional Marketing",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Presentation",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000CB",
                Location = "Ski Lodge - Foggy Brews",
                Name = "STEM Animation",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000CC",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Video Game Design",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Interviews",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000CD",
                Location = "Ski Lodge - Foggy Brews",
                Name = "Website Design",
                StartDateTime = DateTime.Parse("4/21/2023 9:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000CE",
                Location = "Ski Lodge - Maple",
                Name = "Structural Design & Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 10:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Testing",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000CF",
                Location = "Ski Lodge - Maple",
                Name = "Structural Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 10:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Trying to find the right fit college can be an intimidating process, but by asking yourself some simple questions you’ll discover your home away from home in no time.",
                EndDateTime = DateTime.Parse("4/21/2023 11:00"),
                Id = "0000000000000000000000D0",
                Location = "Matterhorn Lounge",
                Name = "Finding Your College: 10 Questions to Help You Think Deeply and Act Boldly",
                StartDateTime = DateTime.Parse("4/21/2023 10:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Competition",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000D1",
                Location = "Timberstone",
                Name = "PA-TSA VEX - HS",
                StartDateTime = DateTime.Parse("4/21/2023 10:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Time Trials",
                EndDateTime = DateTime.Parse("4/21/2023 12:30"),
                Id = "0000000000000000000000D2",
                Location = "Ski Lodge",
                Name = "Junior Solar Sprint",
                StartDateTime = DateTime.Parse("4/21/2023 11:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "A presentation which shows the process and nuclear science behind starting up Penn State’s Breazeale Nuclear Reactor. Students will be able to engage with interactive elements such hands-on simulations of the reactor, and directly communicate with reactor operators aiding them in startup process",
                EndDateTime = DateTime.Parse("4/21/2023 12:00"),
                Id = "0000000000000000000000D3",
                Location = "Matterhorn Lounge",
                Name = "How to Start a Nuclear Reactor",
                StartDateTime = DateTime.Parse("4/21/2023 11:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "PDE Technology & Engineering Content Advisor Brandt Hutzel will discuss the new Technology & Engineering Standards that are part of the STEELS standards suite. In addition, he will share information on the STEP w/EbD Initiative that will support the implementation of the new standards during the next three years.",
                EndDateTime = DateTime.Parse("4/21/2023 13:00"),
                Id = "0000000000000000000000D4",
                Location = "Matterhorn Lounge",
                Name = "New Technology & Engineering Standards, Brandt Hutzel",
                StartDateTime = DateTime.Parse("4/21/2023 12:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000D5",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Architecture",
                StartDateTime = DateTime.Parse("4/21/2023 12:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals - Essay",
                EndDateTime = DateTime.Parse("4/21/2023 14:30"),
                Id = "0000000000000000000000D6",
                Location = "Fox Den",
                Name = "Essays on Technology",
                StartDateTime = DateTime.Parse("4/21/2023 12:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000D7",
                Location = "Seasons #2",
                Name = "Extemporaneous Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000D8",
                Location = "Dogwood",
                Name = "Forensic Science",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals - report write-up",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000D9",
                Location = "Evergreen",
                Name = "Forensic Science",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Construction",
                EndDateTime = DateTime.Parse("4/21/2023 15:00"),
                Id = "0000000000000000000000DA",
                Location = "Laurel",
                Name = "Photographic Technology",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000DB",
                Location = "Seasons #3",
                Name = "Prepared Presentation",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000DC",
                Location = "Chestnut",
                Name = "Forensic Technology",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals - report write-up",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000DD",
                Location = "Evergreen",
                Name = "Forensic Technology",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Drop-off",
                EndDateTime = DateTime.Parse("4/21/2023 13:30"),
                Id = "0000000000000000000000DE",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Do you have an interest or considering a career in software development? Learn what it is like to be one from someone who has been developing software for over 15 years.",
                EndDateTime = DateTime.Parse("4/21/2023 14:00"),
                Id = "0000000000000000000000DF",
                Location = "Matterhorn Lounge",
                Name = "Day in the Life of a Developer, TJ Cappelletti",
                StartDateTime = DateTime.Parse("4/21/2023 13:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 17:30"),
                Id = "0000000000000000000000E0",
                Location = "Ski Lodge",
                Name = "Technology Problem Solving",
                StartDateTime = DateTime.Parse("4/21/2023 13:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Contest",
                EndDateTime = DateTime.Parse("4/21/2023 17:30"),
                Id = "0000000000000000000000E1",
                Location = "Ski Lodge - 2nd Floor",
                Name = "Problem Solving",
                StartDateTime = DateTime.Parse("4/21/2023 13:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Trim/Flights - semifinalists",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000E2",
                Location = "Grand Ballroom",
                Name = "Flight",
                StartDateTime = DateTime.Parse("4/21/2023 14:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 15:30"),
                Id = "0000000000000000000000E3",
                Location = "Ski Lodge",
                Name = "Junior Solar Sprint",
                StartDateTime = DateTime.Parse("4/21/2023 14:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Competition",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000E4",
                Location = "Timberstone",
                Name = "PA - Robotics",
                StartDateTime = DateTime.Parse("4/21/2023 14:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Come to the Minecraft special interest session where you can play survival or creative Minecraft with your friends and TSA peers. There will be a Build Battle event in which competitors will build a TSA-themed work that will be judged by a State Officer. The winner will receive a prize. A personal device is required with Minecraft that can run offline.",
                EndDateTime = DateTime.Parse("4/21/2023 15:00"),
                Id = "0000000000000000000000E5",
                Location = "Matterhorn Lounge",
                Name = "Minecraft Tournament",
                StartDateTime = DateTime.Parse("4/21/2023 14:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Finals",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000E6",
                Location = "Seasons #1",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/21/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Holding",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000E7",
                Location = "Sunburst",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/21/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pro/Con",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000E8",
                Location = "Seasons #2",
                Name = "Debating Technological Issues",
                StartDateTime = DateTime.Parse("4/21/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finalist Presentation",
                EndDateTime = DateTime.Parse("4/21/2023 17:00"),
                Id = "0000000000000000000000E9",
                Location = "Laurel",
                Name = "Photographic Technology",
                StartDateTime = DateTime.Parse("4/21/2023 15:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "How well do you work under pressure? In this year’s Minute to Win It, participants will compete in numerous minute-long challenges ranging from relay races, stacking cards, jelly bean tossing, and more. The participant who wins the most number of challenges will leave the session with a prize!",
                EndDateTime = DateTime.Parse("4/21/2023 16:00"),
                Id = "0000000000000000000000EA",
                Location = "Matterhorn Lounge",
                Name = "Minute to Win It",
                StartDateTime = DateTime.Parse("4/21/2023 15:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Semi-finals",
                EndDateTime = DateTime.Parse("4/21/2023 16:30"),
                Id = "0000000000000000000000EB",
                Location = "Fox Den",
                Name = "Electrical Applications",
                StartDateTime = DateTime.Parse("4/21/2023 15:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick Up",
                EndDateTime = DateTime.Parse("4/21/2023 16:30"),
                Id = "0000000000000000000000EC",
                Location = "Grand Ballroom",
                Name = "PA - R/C Off-Road Racing",
                StartDateTime = DateTime.Parse("4/21/2023 15:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description =
                    "Do you love the tech problem solving competition? Did you not get an opportunity to compete in states for it, but still want to have an awesome time building things to solve a problem? Then this special interest session is for you!! Come join us for a lot of fun and get some tech problem solving done!!!",
                EndDateTime = DateTime.Parse("4/21/2023 15:00"),
                Id = "0000000000000000000000ED",
                Location = "Matterhorn Lounge",
                Name = "Mini Tech Problem Solving",
                StartDateTime = DateTime.Parse("4/21/2023 16:00"),
                Type = "Special Interest"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 18:00"),
                Id = "0000000000000000000000EE",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Architecture",
                StartDateTime = DateTime.Parse("4/21/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 18:00"),
                Id = "0000000000000000000000EF",
                Location = "Alpine",
                Name = "Computer-Aided Design (CAD) Engineering",
                StartDateTime = DateTime.Parse("4/21/2023 17:00"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 18:00"),
                Id = "0000000000000000000000F0",
                Location = "Alpine",
                Name = "Computer-Aided Design Foundations",
                StartDateTime = DateTime.Parse("4/21/2023 17:00"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F1",
                Location = "Winterberry",
                Name = "Animatronics",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F2",
                Location = "Winterberry",
                Name = "Architectural Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F3",
                Location = "Winterberry",
                Name = "Biotechnology Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F4",
                Location = "Winterberry",
                Name = "Board Game Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F5",
                Location = "Winterberry",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F6",
                Location = "Winterberry",
                Name = "Engineering Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F7",
                Location = "Winterberry",
                Name = "Manufacturing Prototype",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F8",
                Location = "Winterberry",
                Name = "PA - Electronic Research & Exp",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000F9",
                Location = "Winterberry",
                Name = "PA - Logo Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FA",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FB",
                Location = "Winterberry",
                Name = "Promotional Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FC",
                Location = "Winterberry",
                Name = "Transportation Modeling",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FD",
                Location = "Winterberry",
                Name = "Virtual Reality Visualization (VR)",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "High School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FE",
                Location = "Winterberry",
                Name = "Biotechnology",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "0000000000000000000000FF",
                Location = "Winterberry",
                Name = "Children's Stories",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000100",
                Location = "Winterberry",
                Name = "Construction Challenge",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000101",
                Location = "Winterberry",
                Name = "Data Science and Analytics",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick Up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000102",
                Location = "Winterberry",
                Name = "Inventions and Innovations",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000103",
                Location = "Winterberry",
                Name = "Mass Production",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000104",
                Location = "Winterberry",
                Name = "Medical Technology",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000105",
                Location = "Winterberry",
                Name = "Microcontroller Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000106",
                Location = "Winterberry",
                Name = "Off the Grid",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000107",
                Location = "Winterberry",
                Name = "PA - Logo Design",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };

        yield return new object[]
        {
            new ConferenceEvent
            {
                Description = "Pick-up",
                EndDateTime = DateTime.Parse("4/21/2023 19:00"),
                Id = "000000000000000000000108",
                Location = "Winterberry",
                Name = "PA - Materials Process",
                StartDateTime = DateTime.Parse("4/21/2023 17:30"),
                Type = "Middle School"
            },
            ConferenceEventDataIssues.None
        };
    }
}

[Flags]
public enum ConferenceEventDataIssues
{
    None = 0
}
