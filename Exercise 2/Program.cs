namespace Exercise_2
{
    internal class Program
    {
        public class Block
        {
            public int AB { get; set; }
            public int BC { get; set; }
            public int CD { get; set; }
            public int DA { get; set; }
           public Block(int ab, int bc, int cd, int da)
            {
                AB = ab;
                BC = bc;
                CD = cd;
                DA = da;
            }
            public override bool Equals(object? obj)
            {
                if (obj == null || this.GetType() != obj.GetType())
                {
                    return false;
                }
                Block block = (Block)obj;
                return(AB==block.AB)&&(BC == block.BC) &&(CD ==block.CD)&&(DA ==block.DA);
            }
            public override int GetHashCode()
            {
                return AB^ BC ^ CD ^ DA;
            }
            public override string ToString()
            {
                return $"{AB} - {BC}  -  {CD} - {DA}";
            }
        }
        static void Main(string[] args)
        {
            Block block = new(1, 2, 3, 4);
            Block block1 = new(1, 2, 3, 4);

            Console.WriteLine(block.Equals(block1));
            Console.WriteLine(block.ToString());
            Console.ReadKey();
        }
    }
}