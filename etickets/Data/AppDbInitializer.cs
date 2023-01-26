using etickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace etickets.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder, AppDbContext context)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<AppDbContext>().Database.EnsureCreated();

                //cinema
                if (!serviceScope.ServiceProvider.GetService<AppDbContext>().Cinemas.Any())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                            Description = "This is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                            Description = "This is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                            Description = "This is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_92x30dp.png",
                            Description = "This is the first description"
                        },

                    });
                    serviceScope.ServiceProvider.GetService<AppDbContext>().SaveChanges();

                }

                //Actors
                if (!serviceScope.ServiceProvider.GetService<AppDbContext>().Actors.Any())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "John Dumelo",
                            Bio = "John Dumelo is a multiple award-winning Ghanaian Actor and producer with over two decades of acting experience. He has featured in over 60 movies.",
                            ProfilePictureURL= "https://www.missginapromotes.com/wp-content/uploads/2019/11/6B1C8070-E61A-4183-9E75-A11148572965-346x420.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Nabila",
                            Bio = "Nabila Rodriguez undeniably has one of the sweetest voices Cameroon has ever known. As an artiste, she has easily penetrated the hearts of several. We know she will steal hearts as she makes her movie debut by playing the character; Patricia Mbole, in Broken.",
                            ProfilePictureURL= "https://www.missginapromotes.com/wp-content/uploads/2019/11/16CFA64F-7206-4EB9-B7CB-7EE723BEFBFB-348x420.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Kang QUINTUS",
                            Bio = "Kang QUINTUS is an actor, director, screenwriter, casting director, editor and producer. Born September 17, 1987, in Wum (Cameroon), he is a multi-award winning cinema professional. He is known for the films",
                            ProfilePictureURL= "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTjKm_vIDreR49Doknapk3moPyZgL7359vNOnPtvi69aMzCzOU6"
                        },
                        new Actor()
                        {
                            FullName = "Ramsey Nouah",
                            Bio = "Ramsey Nouah was born on December 19, 1970 in Lagos, Nigeria. At 20, he was starting out as an aspiring musician prior to heeding a friend's advise to take a stab on acting. At 21, he audition and instantly won the role of Jeff in an on-coming Nigerian television soap opera, Fortunes.",
                            ProfilePictureURL= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRw_IggV52mfZKLjGJp5hQwzAJqW6WcV8InutNXAOyXIlQuZRvnlUQJTys&s"
                        },
                        new Actor()
                        {
                            FullName = "Richard Eyimofe",
                            Bio = "Richard Eyimofe Evans Mofe-Damijo, popularly known as RMD, is a Nigerian actor, writer, producer, lawyer, and former journalist.",
                            ProfilePictureURL= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWJaCK5xDohZJOeETgtZWDJ8Beb4cWNU_SJFTgXVo&s"
                        },
                        new Actor()
                        {
                            FullName = "Iretiola Olusola Doyle",
                            Bio = "Iretiola Olusola Doyle is a Nigerian actress, entertainer, TV presenter, writer and a public speaker",
                            ProfilePictureURL= "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcRwQHZW0hJW1LOEO15hPa13LeDgqbugZpF14coYVrKKicaQHGRKCq0nPCfhU-MO9j5qk52i2yNivEivuE4"
                        },
                        new Actor()
                        {
                            FullName = "Lucie Memba Bos",
                            Bio = "Lucie Memba Bos is a Cameroonian actress, movie producer who have starred in both series and movies in French and English language.",
                            ProfilePictureURL= "https://cdn.camerounweb.com/imagelib/pics/161/16160569.295.jpg"
                        },
                    });
                    serviceScope.ServiceProvider.GetService<AppDbContext>().SaveChanges();
                }

                //Producers
                if (!serviceScope.ServiceProvider.GetService<AppDbContext>().Producers.Any())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = " Enah Johnscott ",
                            Bio = "ENAH JOHNSCOTT is a Cameroonian independent filmmaker based in Douala. He has a strong background working on professional features of all genres. A very friendly person who is passionate about film making with a strong urge for learning and skill development.",
                            ProfilePictureURL = "https://filmfreeway-production-storage-01-storage.filmfreeway.com/press_kits/headshots/001/380/520/original/4214b6551b-headshot.jpg?1566794209"
                        },
                        new Producer()
                        {
                            FullName = "Ermelinde Simo Jing Sakah",
                            Bio = "Ermelinde Simo Sakah Jing, (born Ermelinde Simo Sakah on 17 September 1982) is a Cameroonian civil servant, Beauty Queen, Model, Mother, Actor and Movie Producer who has gone a long way in boosting Cameroon's movie industry",
                            ProfilePictureURL = "https://scontent-mad1-1.xx.fbcdn.net/v/t1.6435-9/171910083_3941937355888101_7035115845660002505_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=730e14&_nc_ohc=AWak7KUvmlYAX_Q_-Fo&_nc_ht=scontent-mad1-1.xx&oh=00_AfA3txv2rov3Z4O0AHegML2OAYYY2DIpuRjCfWa9UVztUA&oe=63DB33AD"
                        },
                        new Producer()
                        {
                            FullName = "Syndy Emade",
                            Bio = "Syndy Emade is a multiple award winning Cameroonian actress and producer. She made her acting debut in 2010, and ever since then, she has featured in over 20 movies in Cameroon, Ghana and Nigeria.",
                            ProfilePictureURL = "https://www.missginapromotes.com/wp-content/uploads/2019/11/AC2A1518-F3CD-4048-B308-602EEF078F11-333x420.jpeg"
                        },
                    });
                    serviceScope.ServiceProvider.GetService<AppDbContext>().SaveChanges();
                }

                //Movies
                if (!serviceScope.ServiceProvider.GetService<AppDbContext>().Movies.Any())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Fisherman's Diary",
                            Description ="A 12-year-old girl - Ekah (Faith Fidel) - is inspired by Malala Yousafzai's story and is determined to get an education. In a village of uneducated fishermen, she gets entangled with her father's - Solomon (Kang Quintus) - past experience with girl child education.",
                            Price = 32,
                            ImgURL = "https://upload.wikimedia.org/wikipedia/en/c/cb/The_Fisherman%27s_Diary.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Therapy",
                            Description ="Therapy is directed by Anurin Nwunembom & Musing Derick The movie dramatises a dysfunctional couple that hires the services of an unconventional therapist in an effort to solve their marital troubles. Mr. Lima is almost losing his mind over his wife's psychological pain. The methods of Dr. Benedicta leads the couple to discover truths that threaten the couple more",
                            Price = 39,
                            ImgURL = "https://www.atlanticchronicles.com/wp-content/uploads/2019/12/Therapys-crew-1.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Broken",
                            Description ="After running away from her marriage, a woman enters a dangerous agreement with an unfamiliar man to save her father’s company and her reputation.",
                            Price = 29,
                            ImgURL = "https://54ze41.n3cdn1.secureserver.net/wp-content/uploads/2019/11/FB_IMG_1572462803820.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                    });
                    serviceScope.ServiceProvider.GetService<AppDbContext>().SaveChanges();
                }

                //Actors & Movies
                if (serviceScope.ServiceProvider.GetService<AppDbContext>().Actors_Movies.Any())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 2,
                        },

                    });
                    serviceScope.ServiceProvider.GetService<AppDbContext>().SaveChanges();
                }
            }
        }
        internal static void Seed(WebApplication app)
        {
            
        }

    }
}
