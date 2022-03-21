with open("input.txt", "r+") as file:

    full_data = file.read()
    lines = full_data.splitlines()

key_words = [

    # Loops
    "while",
    "if",
    "else",
    "else if",
    "catch",
    "try",

    # Prints
    "Write(",
    "WriteLine(",

    # Functions
    "staggeredPrint(",
    "stagWait(",
    "changeGame(",
    "game1(",
    "game2(",
    "game3(",
    "outro(",

    # Variable items / params
    "true",
    "false",
    "\"\"",
    "[",
    "]",
    "{",
    "}",

    # Variable names
    "bool",
    "string",
    "int",
    "float",
    "dynamic",

    # Maths / Equations
    "=",
    ">",
    "<",
    "==",
    "<=",
    ">=",
    "-",
    "*",
    "+",
    "/"

]

def get_kw(line):

    for k in key_words:

        if k in line:

            print(line)

for line in lines:

    get_kw(line)
