namespace Giraffe1{
    class House{
        public int houseNumber;
        public string houseOwnerFirstName;
        public string houseOwnerLastName;
        public int zipcode;
        public int price;

        public static int count = 0;
        public House(int houseNum, string houseOwnerFirstName, string houseOwnerLastName, int zipcode, int price){
            this.houseNumber = houseNum;
            this.houseOwnerFirstName = houseOwnerFirstName;
            this.houseOwnerLastName = houseOwnerLastName;
            this.zipcode = zipcode;
            Price = price;
            count++;
        }

        public bool IsInNineThousand(){
            if(this.zipcode >= 90000 && this.zipcode<=99999)
                return true;
            else  
                return false;
        }

        public int Price{
            get{
                return this.price;
            }
            set{
                this.price = value;
            }
        }
    }
}