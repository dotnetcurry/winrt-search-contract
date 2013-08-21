using System.Collections.ObjectModel;

namespace Store_CS_Search_Contract
{
    /// <summary>
    /// Class to Store Description of the Travel Location
    /// </summary>
    public class LocationDetails
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    /// <summary>
    /// Class contains One to Many detsils of the Travel Location
    /// </summary>
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string State { get; set; }
        public ObservableCollection<LocationDetails> Details { get; set; }
    }


    /// <summary>
    /// Class containing Travel Location Details
    /// </summary>
    public class TravelDetails : ObservableCollection<Location>
    {
        public TravelDetails()
        {
            Add(new Location()
            {
                LocationId = 1,
                LocationName = "Mahabaleshwar",
                State="Maharashtra",
                Details = new ObservableCollection<LocationDetails>() 
                {
                  new LocationDetails() {Description="Elephant Rock",ImageUrl="./Assets/LocationImages/Mahb_ElephantRock.jpg"},
                  new LocationDetails() {Description="Arthur's Chair",ImageUrl="./Assets/LocationImages/Mahb_ArthurChair.jpg"},
                  new LocationDetails() {Description="Mahabaleshwar Lake",ImageUrl="./Assets/LocationImages/Mahb_Lake.jpg"},
                  new LocationDetails() {Description="Pratapgarh",ImageUrl="./Assets/LocationImages/Mahb_Pratapgarh.jpg"}
                }
            });

            Add(new Location()
            {
                LocationId = 2,
                LocationName = "Kanyakumari",
                State = "Tamil Nadu",
                Details = new ObservableCollection<LocationDetails>() 
                {
                  new LocationDetails() {Description="Indian Ocean",ImageUrl="./Assets/LocationImages/Kanya_Indian_Ocean.jpg"},
                  new LocationDetails() {Description="Sunset View",ImageUrl="./Assets/LocationImages/Kanya_Sunset.jpg"},
                  new LocationDetails() {Description="Swami Vivekanand Rock View",ImageUrl="./Assets/LocationImages/Kanya_Vivekanand_ROck_1.jpg"},
                  new LocationDetails() {Description="Swami Vivekanand Rock View",ImageUrl="./Assets/LocationImages/Kanya_Vivekanand_ROck_2.jpg"}
                }
            });

            Add(new Location()
            {
                LocationId = 3,
                LocationName = "Murudeshwar",
                State="Karnataka",
                Details = new ObservableCollection<LocationDetails>() 
                {
                  new LocationDetails() {Description="Sea Beach",ImageUrl="./Assets/LocationImages/Murud_Beach.jpg"},
                  new LocationDetails() {Description="Hotel View",ImageUrl="./Assets/LocationImages/Murud_Hotel.jpg"},
                  new LocationDetails() {Description="Lord Mahadeva Statue",ImageUrl="./Assets/LocationImages/Murud_LordShankar_1.jpg"},
                  new LocationDetails() {Description="Lord Magadeva Status",ImageUrl="./Assets/LocationImages/Murud_LordShankar_2.jpg"},
                  new LocationDetails() {Description="Temple View 1",ImageUrl="./Assets/LocationImages/Murud_TempleView.jpg"},
                  new LocationDetails() {Description="Temple View 2",ImageUrl="./Assets/LocationImages/Murud_TempleView1.jpg"}
                }
            });

            Add(new Location()
            {
                LocationId = 4,
                LocationName = "Rameshwaram",
                State="Tamil Nadu",
                Details = new ObservableCollection<LocationDetails>() 
                {
                  new LocationDetails() {Description="Sea Beach",ImageUrl="./Assets/LocationImages/Ram_Beach.jpg"},
                  new LocationDetails() {Description="Rameshwaram Temple",ImageUrl="./Assets/LocationImages/Ram_Temple_1.jpg"}
                }
            });
        } 
    }
}
