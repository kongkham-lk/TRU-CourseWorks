import math

# Syllable – any word of 3 characters or less; any vowel (a,e,i,o,u) or consecutive vowels, excepting the endings of –ed,-es,or –e where it is not –le,
def countSyllable(word, validVowel, invalidVowel):
    print(word + ":", end="")
    if len(word) <= 3:
        print(" + 1")
        return 1
    word = word.lower()
    count = 0
    isPrevVowel = False

    for i in range(0, len(word)):
        if (not isPrevVowel and word[i] in validVowel and (i != len(word)-1
                or (i == len(word)-1 and (word[i] != 'e' and word[i-1:i+1] not in invalidVowel) or word[i-1:i+1] == "le"))):
            count = count + 1
            print(" + 1", end="")
            isPrevVowel = True
        elif word[i] not in validVowel:
            isPrevVowel = False
    print()
    return count

def countWord(sentence):
        wordList = sentence.split()
        wordsCount = wordsCount + len(wordList)
        return wordList, wordsCount

def countSentence(fileTxt):
    symbols = ["!", "?", ":", ";"]

    # replace all the potential symbol to fullstop
    for symbol in symbols:
        sentenceList = fileTxt.replace(symbol, ".").replace("?", ".").strip("\n").split(".")

    sentenceList = fileTxt.strip("\n").split(".") # split sentence into different element
    print("sentence >>" ,sentenceList)
    sentencesCount = len(sentenceList)
    return sentenceList, sentencesCount

def countElementOfText(fileTxt):
    wordsCount, sysllableCount = 0, 0
    validVowel = ['a','e','i','o','u']
    invalidVowel = ['ed', 'es']
    sentences, sentenceCount = countSentence(fileTxt)
    for sentence in sentences:
        words, wordsCount = countWord(sentence)
        for word in words:
            word = word.strip(", ") #remove comma
            sysllableCount = sysllableCount + countSyllable(word, validVowel, invalidVowel)
    return sentenceCount, wordsCount, sysllableCount

def getF(sentences, words, syllables):
    return 206.835 - 1.015 * (words / sentences) - 84.6 * (syllables / words)

def getG(sentences, words, syllables):
    return 0.39 * (words / sentences) + 11.8 * (syllables / words) - 15.59

if __name__ == "__main__": # main function header
    f = open("myfile.txt", 'r')
    text = f.read()
    f.close()
    print()
    sentenceCount, wordCount, sysllableCount = countElementOfText(text)

    result = f"\nSentences Count: {sentenceCount}\nWords Count: {wordCount}\nSysllable Count: {sysllableCount}\n"
    print(result)
    print("F =", getF(sentenceCount, wordCount, sysllableCount))
    print("G =", getG(sentenceCount, wordCount, sysllableCount), "\n")