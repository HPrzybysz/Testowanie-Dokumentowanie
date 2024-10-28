import org.example.Calculator;
import org.junit.Assert;
import org.junit.Test;
import org.junit.runners.Parameterized;

public class CalculatorTest {
    @Test
    public void testAdd() {
        Calculator calc = new Calculator();

        int result = calc.add(1, 2);
        assert result == 3;


    }

    @Test
    public void testSubtract() {
        Calculator calc = new Calculator();
        int result = calc.subtract(1, 2);
        assert result == -1;
    }

    @Test
    public void testSubstract2(){
        Calculator calc = new Calculator();
        int result = calc.subtract(2139, 2);
        assert result == 2137;
    }

//    @ParameterizedTest
//    @ValueSource(ints={6,})
//    public void testAddd(int number){
//        Calculator calc = new Calculator();
//        int result = calc.add(number, 2);
//        assert result == 2;
//    }



}
