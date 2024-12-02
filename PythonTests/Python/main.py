import unittest
import pytest

class TestClass(unittest.TestCase):
    def test_upper(self):
        self.assertEqual("Foo".upper(), "FOO")
    def test_lower(self):
        self.assertEqual("Foo".lower(),'foo')

    def test_fibbonacci(self):
        self.assertEqual(fibbonacci(100),0)

@pytest.mark.parametrize("a, b, result", [(1,2,3), (2,3,5)])
def test_addition(a, b, result):
    assert result == a + b

def testfibbonacci():
    assert fibbonacci(3)==2

def addition(a, b) -> int:
    return a + b

def fibbonacci(n):
    if n <= 2:
        return n
    else:
        return fibbonacci(n-1) + fibbonacci(n-2)

if __name__ == '__main__':
    unittest.main()
    pytest.main()