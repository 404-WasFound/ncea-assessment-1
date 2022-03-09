import time

def type(text):

    for char in text:

        print(char, end="")
        time.sleep(0.5)

    print("\n", end="")