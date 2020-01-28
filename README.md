# ObjectJsonLite
C# class for converting any object to a Json string, without using Newtonsoft
## Usage
#### include properties name/value with null values in json string
```
YourObjectHere example1 = new YourObjectHere();

string json1 = ObjectJsonLite.Serialize(example1);
```
#### exclude properties name/value with null values in json string
```
YourObjectHere exmample2 = new YourObjectHere();

string json2 = ObjectJsonLite.Serialize(example2, true);
```

## Contribute
#### Bugs
If you find a bug, please report it on this GitHub page, email me, or if you find the fix yourself, pull request the code with notes into master	
#### Features
##### Planned:
Include IEnumerable Support
Convert Json string to C# object without Newtonsoft library
##### Unplanned:
If you think of a feature or improvement please email me or pull request your code into master
