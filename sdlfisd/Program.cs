

namespace sdlfisd
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000);

            GiftBox[] giftBoxes = new GiftBox[3];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;
            Console.WriteLine("giftBox Array Count : " + giftBoxes.Length);
            

            //List~~~
            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA); //0
            giftBoxList.Add(addressB); //1
            giftBoxList.Add(addressC); //2

            Console.WriteLine("giftbox List Count :" + giftBoxList.Count);

            for (int i = 0; i < giftBoxes.Length; i++)
            {
                giftBoxes[i].Letter = (i + 1) + "번째 편지";
                Console.WriteLine(giftBoxList[i].Letter);
            }

            foreach (GiftBox gift in giftBoxes)
            { 
                Console.WriteLine(gift.Letter);
            }

        }



        private static string add(int v1, int v2)
        {
            int num = v1 + v2;
            return num + "입니다.";
        }

        private static GiftBox GiftBoxMaker(string letter, int money)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money
            };
            return addressA;
        }

        private static void AddressC()
        {
            GiftBox addressC = new GiftBox()
            {
                Letter = "C 친구야 잘 지내지?",
                Money = 130000
            };
        }

        private static void AddressB()
        {
            GiftBox addressB = new GiftBox()
            {
                Letter = "B 친구야 잘 지내지?",
                Money = 120000
            };
        }

        private static void AddressA()
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = "A 친구야 잘 지내지?",
                Money = 110000
            };
        }
    }
}
