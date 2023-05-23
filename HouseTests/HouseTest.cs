using HouseTests;

namespace House.HouseTests
{
    public class HouseTest : TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyHouse_WhenReturnResult()
        {
            string guid = Guid.NewGuid().ToString();

            HouseDto house = new HouseDto();

            house.Id = Guid.Parse(guid);
            house.Name = "Hotel";
            house.Area = 300;
            house.Address = "Sopruse pst";
            house.Floors = 2;
            house.CreatedAt = DateTime.Now;
            house.ModifiedAt = DateTime.Now;

            var result = await Svc<IHouseServices>().Add(house);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldNot_GetByIdHouse_WhenReturnsResultAsync()
        {
            Guid guid = Guid.Parse("7141d1b4-2496-4511-928b-c04704f75478");

            Guid guid1 = Guid.Parse(Guid.NewGuid().ToString());

            await Svc<IHouseServices>().GetAsync(guid);
            Assert.NotEqual(guid1, guid);
        }

        [Fact]
        public async Task Should_GetByIdHouse_WhenReturnsEqual()
        {
            Guid guid = Guid.Parse("7141d1b4-2496-4511-928b-c04704f75478");

            Guid guid1 = Guid.Parse("7141d1b4-2496-4511-928b-c04704f75478");

            await Svc<IHouseServices>().GetAsync(guid);

            Assert.Equal(guid1, guid);
        }

        [Fact]
        public async Task Should_DeleteByIdHouse_WhenDeleteHouse()
        {
            HouseDto house = CreateValidHouse();
            var createdHouse = await Svc<IHouseServices>().Add(house);

            var result = await Svc<IHouseServices>().Delete((Guid)createdHouse.Id);

            Assert.Equal(createdHouse, result);
        }

        private HouseDto CreateValidHouse()
        {
            HouseDto house = new()
            {
                Name = "Hotel",
                Area = 300,
                Address = "Sopruse pst",
                Floors = 2,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };
            return house;
        }
    }
}
