from find_difference import extra_character_index

string1_list = ["wxyz", "cbda", "jlkmn", "courae", "hello"]
string2_list = ["zwxgy", "abc", "klmn", "couearg", "helo"]

for i in range(len(string1_list)):
    print(f"{i + 1}.\tString 1 = {string1_list[i]}")
    print(f"\tString 2 = {string2_list[i]}")
    print(f"\n\tThe extra character is at index: {
          extra_character_index(string1_list[i], string2_list[i])}")
    print('-' * 100)
