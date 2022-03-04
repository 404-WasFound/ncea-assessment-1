from time import sleep

def stagPrint(text):

    for c in text:

        print(c, end="")
        sleep(0.05)

    print("\n")