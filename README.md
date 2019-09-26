# ObjectJsonLite
C# class for converting any object to a Json string, without using Newtonsoft

## Usage
#### include properties name/value with null values in json string

YourObjectHere example1 = new YourObjectHere();

string json1 = ObjectJsonLite.Serialize(example1);

#### exclude properties name/value with null values in json string

YourObjectHere exmample2 = new YourObjectHere();

string json2 = ObjectJsonLite.Serialize(example2, true);
