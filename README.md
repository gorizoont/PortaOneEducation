# PortaOne Education Test Task
## How it works?
- ### Step 1 - Enter text.
User enters text.

***Console.ReadLine*** Method - reads the next line of characters from the standard input stream.
~~~
string? enterstring = Console.ReadLine();
~~~

- ### Step 2 - Word search.
***String.Split*** Method - returns a string array that contains the substrings in this instance that are delimited by elements of a specified string or Unicode character array.
~~~
string[] words = enterstring.Split(new char[] {' ', '.', ',', '-', '"', '\n', '\r', '\"'}, StringSplitOptions.RemoveEmptyEntries);
~~~

The ***String.Split*** method returns an array of the substrings in a given string that are delimited by specified characters or strings. Adjacent delimiters yield an array element that contains an empty string (""). One of the fields of the ***StringSplitOptions*** enumeration specifies whether an element that contains an empty string should be included in the returned array.

- ### Step 3 - Char search.
~~~
var result = SearchChar(SearchWord(words));
~~~
- #### Step 3.1 - Search in word

***String.IndexOf*** Method - reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.

***String.LastIndexOf*** Method - reports the zero-based index position of the last occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.

  ~~~
  static string SearchWord(string[] str)
    {
        string liters = "";

        foreach (string word in str)
        {
            foreach (char c in word)
            {
                if (word.IndexOf(c) == word.LastIndexOf(c))
                {
                    liters += c;
                    break;
                }
            }
        }
        return liters;
    }
  ~~~
  

  - #### Step 3.2 - Search in string.
If the method finds a character with IndexOf = LastIndexOf then returns it.
  ~~~
  static char SearchChar(string strword)
    {
        foreach (char symb in strword)
        {
            if (strword.IndexOf(symb) == strword.LastIndexOf(symb))
            {
                return symb;
            }
        }
        return ' ';
    }
  ~~~

- ### Step 4 - Show result.
The ***if else*** checks a Boolean expression and executes the code based on if the expression is **true** or **false**. The ***if*** part of the code executes when the value of the expression is **true**. The ***else*** part of the code is executed when the value of the expression is **false**.
~~~
        if (result != ' ')
            Console.WriteLine("Your result: {0}", result);
        else
            Console.WriteLine("You enter empty string or no unique characters!");
~~~
***Console.WriteLine*** Method - writes the specified data, to the standard output stream.




---
---

## Available platforms
- [Windows](#windows)
- [Linux](#linux)
- [Docker](#docker)

##  Windows
> **Warning**
>The application works on **.NET 7**

### Install .NET on Windows

The latest version of .NET is 7.

<a href="https://dotnet.microsoft.com/en-us/download/dotnet/7.0">Download .NET 7</a>

There are two types of supported releases, Long Term Support (LTS) releases or Standard Term Support (STS). The quality of all releases is the same. The only difference is the length of support. LTS releases get free support and patches for 3 years. STS releases get free support and patches for 18 months.

- ### Install with Windows Package Manager (winget)

You can install and manage .NET through the Windows Package Manager service, using the winget tool. For more information about how to install and use winget, see Use the winget tool.

If you're installing .NET system-wide, install with administrative privileges.

Install the SDK
To install the .NET SDK, run the following command:

~~~
winget install Microsoft.DotNet.SDK.7
~~~

- ### Run App

In PowerShell or terminal open project <a href="https://github.com/gorizoont/PortaOneEducation">folder</a> and go to <a href="https://github.com/gorizoont/PortaOneEducation/tree/main/TestTask">TestTask</a>.

In <a href="https://github.com/gorizoont/PortaOneEducation/tree/main/TestTask">TestTask</a> folder use command:

~~~
dotnet run
~~~

Example:

~~~
C:\PortaOneEducation\TestTask>dotnet run
Enter Your text: C makes it easy for you to shoot yourself in the foot.
Your result: C
Press any key to close the console app...
~~~


##  Linux
> **Warning**
>The application works on **.NET 7**
- ### Install .NET on Linux
You can install .NET manually in the following ways:
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-scripted-manual#manual-install">Manual</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-scripted-manual#scripted-install">Scripted</a>

You may need to install .NET dependencies if you install .NET manually.

- ### Packages
.NET is available in official package archives for various Linux distributions and packages.microsoft.com.
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-alpine">Alpine</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-centos">CentOS</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-debian">Debian</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-fedora">Fedora</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-opensuse">openSUSE</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-sles">SLES</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-snap">Snap</a>
- <a href="https://learn.microsoft.com/uk-ua/dotnet/core/install/linux-ubuntu">Ubuntu</a>

.NET is supported by Microsoft when downloaded from a Microsoft source. Best effort support is offered from Microsoft when downloaded from elsewhere. You can open issues at dotnet/core if you run into problems.

- ### Run App

In terminal open project <a href="https://github.com/gorizoont/PortaOneEducation">folder</a> and go to <a href="https://github.com/gorizoont/PortaOneEducation/tree/main/TestTask">TestTask</a>.

In <a href="https://github.com/gorizoont/PortaOneEducation/tree/main/TestTask">TestTask</a> folder use command:

~~~
dotnet run
~~~

Example:

~~~
gorizont@GORIZONT:~/PortaOneEducation/TestTask$ dotnet run
Enter Your text: C makes it easy for you to shoot yourself in the foot.
Your result: C
Press any key to close the console app...
~~~



##  Docker
> **Warning**
>Docker version **20.10.21, build baeda1f**
- ### Image Pull

~~~
docker pull gorizzont/porta-one-task:1.0
~~~

- ### Run App

~~~
docker run [OPTIONS] IMAGE [COMMAND] [ARG...]
~~~

Example:

~~~
gorizont@GORIZONT:~$ docker run -it dc9c4d90
Enter Your text: C makes it easy for you to shoot yourself in the foot.
Your result: C
Press any key to close the console app...
~~~

For more information about using .NET in a Docker container, see <a href="https://learn.microsoft.com/uk-ua/dotnet/core/docker/introduction">Introduction to .NET and Docker </a> and <a href="https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md">Samples</a>.
