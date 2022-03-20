from time import sleep


# Menu function
def get_menu(list_of_data, max_item_length):

    # Setup
    lod = list_of_data
    mil = max_item_length
    limited_itemS = []

    for item in lod:

        if len(item) > mil:

            # Calculate remainder of characters
            substring_count = len(item) - mil
            # Limits charcters in item
            limited_item = item[:-substring_count]
            # Add the limited_item to the list of items
            limited_itemS.append(limited_item)

        if len(item) < mil:

            # Calculate remainder of characters
            addstring_count = mil - len(item)
            # Add spaces to item
            limited_item = item + " " * addstring_count
            # Add the limited_item to the list of items
            limited_itemS.append(limited_item)

    # Create menu

    # Calculate topper string length
    topper_length = mil + 4
    # Create line of equals relative to max item length size
    topper_string = "=" * topper_length
    # List of final lines
    final_lineS = []

    # Add items to menu
    for l_item in limited_itemS:

        # Add edging
        final_line = "| "
        # Add item to line and edging
        final_line += l_item + " |"
        # Add line to list of final lines
        final_lineS.append(final_line)



    # FINAL MENU STRING

    final_string = ""

    # Add topper string
    final_string += topper_string + "\n"

    # Add all the lines in final_lineS
    for line in final_lineS:
        final_string += line + "\n"

    # Add the bottom line
    final_string += topper_string



    # Return the final string of the menu
    return final_string




# NOT IN FUNCTION

player_name = "jeff"
player_score = 20

menu_data = [
    f"Player Name: {player_name}",
    f"Player Score: {player_score}"
]

max_item_length = 30

menu_string = get_menu(menu_data, max_item_length)

print(menu_string)


sleep(999)