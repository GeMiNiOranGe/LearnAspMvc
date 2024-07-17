using Source.Models;

namespace Source.Services {
    public class PlanetService : List<PlanetModel> {
        public PlanetService() {
            AddRange([
                new PlanetModel() {
                    Id = 1,
                    Name = "Mercury",
                    Description = "Mercury (0.31–0.59 AU from the Sun) is the smallest planet in the Solar System. Its surface is greyish, with an expansive rupes (cliff) system generated from thrust faults and bright ray systems formed by impact event remnants. In the past, Mercury was volcanically active, producing smooth basaltic plains similar to the Moon. It is likely that Mercury has a silicate crust and a large iron core. Mercury has a very tenuous atmosphere, consisting of solar-wind particles and ejected atoms. Mercury has no natural satellites.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg"
                },
                new PlanetModel() {
                    Id = 2,
                    Name = "Venus",
                    Description = "Venus (0.72–0.73 AU) has a reflective, whitish atmosphere that is mainly composed of carbon dioxide. At the surface, the atmospheric pressure is ninety times as dense as on Earth's sea level. Venus is the hottest planet, with surface temperatures over 400 °C (752 °F), mainly due to the amount of greenhouse gases in the atmosphere. The planet lacks a protective magnetic field to protect against stripping by the solar wind, which suggests that its atmosphere is sustained by volcanic activity. Its surface displays extensive evidence of volcanic activity with stagnant lid tectonics. Venus has no natural satellites.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg"
                },
                new PlanetModel() {
                    Id = 3,
                    Name = "Earth",
                    Description = "Earth (0.98–1.02 AU) is the only place in the universe where life and surface liquid water are known to exist. Earth's atmosphere contains 78% nitrogen and 21% oxygen, which is the result of the presence of life. The planet has a complex climate and weather system, with conditions differing drastically between climate regions. The solid surface of Earth is dominated by green vegetation, deserts and white ice sheets. Earth's surface is shaped by plate tectonics that formed the continental masses. Earth's planetary magnetosphere shields the surface from radiation, limiting atmospheric stripping and maintaining life habitability.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cb/The_Blue_Marble_%28remastered%29.jpg"
                },
                new PlanetModel() {
                    Id = 4,
                    Name = "Mars",
                    Description = "Mars (1.38–1.67 AU) has a radius about half of that of Earth. Most of the planet is red due to iron oxide in Martian soil, and the polar regions are covered in white ice caps made of water and carbon dioxide. Mars has an atmosphere composed mostly of carbon dioxide, with surface pressure 0.6% of that of Earth, which is sufficient to support some weather phenomena. Its surface is peppered with volcanoes and rift valleys, and has a rich collection of minerals. Mars has a highly differentiated internal structure, and lost its magnetosphere 4 billion years ago.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png"
                },
                new PlanetModel() {
                    Id = 5,
                    Name = "Jupiter",
                    Description = "Jupiter (4.95–5.46 AU) is the biggest and most massive planet in the Solar System. On the surface, there are orange-brown and white cloud bands moving via the principles of atmospheric circulation, with giant storms swirling on the surface such as the Great Red Spot and various white 'ovals'. Jupiter possesses a very strong magnetosphere, enough to redirect ionizing radiation and cause auroras on its poles. As of 2024, Jupiter has 95 confirmed satellites.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c1/Jupiter_New_Horizons.jpg"
                },
                new PlanetModel() {
                    Id = 6,
                    Name = "Saturn",
                    Description = "Saturn (9.08–10.12 AU) has a distinctive visible ring system orbiting around its equator, which is composed of small ice and rock particles. Like Jupiter, it is mostly made of hydrogen and helium. At its north and south poles, Saturn has peculiar hexagon-shaped storms larger than the diameter of Earth. Saturn has a magnetosphere capable of producing weak auroras. As of 2024, Saturn has 146 confirmed satellites.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg"
                },
                new PlanetModel() {
                    Id = 7,
                    Name = "Uranus",
                    Description = "Uranus (18.3–20.1 AU), uniquely among the planets, orbits the Sun on its side as its axial tilt is >90°. This gives the planet extreme seasonal variation as each pole points toward and then away from the Sun. Uranus's outer layer has a muted cyan color, but underneath these clouds contain many mysteries about its climate phenomena, such as its unusually low internal heat and erratic cloud formation. As of 2024, Uranus has 28 confirmed satellites.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/69/Uranus_Voyager2_color_calibrated.png"
                },
                new PlanetModel() {
                    Id = 8,
                    Name = "Neptune",
                    Description = "Neptune (29.9–30.5 AU) is the furthest planet known in the Solar System. Its outer atmosphere has a slightly muted cyan color, with occasional storms on the surface that look like dark spots. Like Uranus, many atmospheric phenomena of Neptune are still unexplained, such as the thermosphere's abnormally high temperature or the strong tilt (47°) of its magnetosphere. As of 2024, Neptune has 16 confirmed satellites",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b9/Neptune_Voyager2_color_calibrated.png"
                },
            ]);
        }
    }
}
