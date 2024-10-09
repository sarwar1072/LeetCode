namespace RemoveDuplicateFrmSrtList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int n= RemoveDuplicates(arr);
            Console.WriteLine(n);
        }       
        public static int RemoveDuplicates(int[] nums)
        {               
            int k=nums.Length;
            bool variante;

            for(int i=0;i<nums.Length-1;i++){

                variante=false;

                for(int j=i;j<k;j++){

                    if(nums[i]==nums[j] ){

                        k--;
                        variante=true;
                    }

                    if(variante==true && j < nums.Length-1){

                        nums[j]=nums[j+1];
                    }
                }
            }
            return k;
              
            //int k = nums.Length;
            //List<int> lista = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (lista.Contains(nums[i]))
            //    {
            //        k--;
            //    }
            //    else
            //    {
            //        lista.Add(nums[i]);
            //    }
            //}

            //for (int j = 0; j < k; j++)
            //{
            //    nums[j] = lista[j];
            //}

            //return k;
            }
        }
    }

