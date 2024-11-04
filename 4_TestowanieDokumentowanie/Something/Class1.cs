namespace _4_TestowanieDokumentowanie
{

    public interface IClass
    {
        int Something(int a);
    }

    public class Class1:IClass
    {
        public int Something(int a)
        {
            if (a < 0)
            {
                return -1;
            }
            else if (a == 0)
            {
                return 10;
            }
            else
            {
                return a * 100;
            }

        }
    }
}
