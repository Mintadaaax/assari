class program {
    static void Main(string[] args){

        Console.WriteLine("input number : ");
        int number = int.Parse(Console.ReadLine());
        int front = number;
        int x = 1;

        for(int i = 0;i < number-1;i++){


        int last = 0 ;

            for(int j = front-1; j > 0 ;j--){
                Console.Write(" ");
                last++;
            }

            if(i == 0){
                Console.Write("#");
                Console.WriteLine();
            }

            front -= 1;


            if(i >= 1){
                //ตัวเปิด
                Console.Write("#");

                for(int o = 0 ; o < x ; o++){
                    Console.Write(" ");
                    last++;
                }

                Console.Write("#");

                x += 2;
                last+= 2;
                Console.WriteLine();
            }
            if(i == number-2){
                for(int l = 0; l <= last ; l++){
                    Console.Write("#");
                }
            }

        }
    }
}
