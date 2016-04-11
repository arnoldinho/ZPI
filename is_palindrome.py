def is_palindrome(string):
    if len(string) <= 1:
        return 1
    elif string[0] == string[-1]:
        return(is_palindrome(string[1:-1]))
    else:
        return 0

#print is_palindrome("kajak")
#print is_palindrome("kajak")
