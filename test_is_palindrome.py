import unittest
from is_palindrome import is_palindrome

class StringValues(unittest.TestCase):
    stringValues=( ("potop", 1),
                  ("kajak", 1),
                  ("owocowo", 1),
                  ("radar", 1))            
    def testIsPalindromeStringValues(self):
        for word, number in self.stringValues:
            result = is_palindrome(word)
            self.assertEqual(number, result)
        
if __name__ == '__main__':
    unittest.main()
