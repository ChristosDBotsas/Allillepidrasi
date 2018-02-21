using System.Drawing;

namespace Allilepidrasi
{
    //static variables for project state usage
    static class Global
    {
        //Temprature globals
        public static int TempratureSetting = 0;
        public static int TempratureDegrees = 18;
        public static Bitmap TempratureImage = Properties.Resources.Heating;

        //Room lighting globals
        public static bool IsBathroomDark = false;
        public static bool IsBedroomDark = false;
        public static bool IsKitchenDark = false;
        public static bool IsLivingRoomDark = false;

        //Wardrobe global
        public static int DressingOccasion = 0;
        public static Bitmap DressingTopImage = Properties.Resources.hoodie;
        public static Bitmap DressingPantsImage = Properties.Resources.jeans;
        public static Bitmap DressingShoesImage = Properties.Resources.sneakers;
    }
}
