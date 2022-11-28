// See https://aka.ms/new-console-template for more information
// data type
//string name = "Hoo Hoo";
using Laboop00A;

int age = 20;// ตัวเลขเต็ม
double weight = 0.300; //ตัวเลขทศนิยม
bool isMan = true; //ตรรกะศาสตร์

int Nst = 5;
string name1 = "Aopi";
string name2 = "Bopi";
string name3 = "Copi";
string name4 = "Dopi";
string name5 = "Eopi";

float weiht1 = 10.6f;
float weiht2 = 13.6f;
float weiht3 = 18.9f;
float weiht4 = 18.7f;
float weiht5 = 20.8f;

Student student1= new Student();
student1.name= "Hopl";
student1.weight = 300f;

Student student2 = new Student();
student2.name = "Popopl";
student2.weight = 30f;

Student student3 = new Student();
student3.name = "Koji";
student3.weight = 90f;

Student student4 = new Student();
student4.name = "Shota";
student4.weight = 10f;

Student student5 = new Student();
student5.name = "Soul";
student5.weight = 50f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 2;
Console.WriteLine("Weight avg os Student : " + avgWeight);
Console.WriteLine("น้ำหนักของคนที่มีน้ำหนักมากที่สุด คือ", "Hopl ", "หนัก ", 300);
Console.WriteLine("น้ำหนักของคนที่มีน้ำหนักน้อยที่สุด คือ", "Shota", "หนัก ", 10);
Console.WriteLine("นาย กฤตชวกร ชวลิตกิตติวงศ์ รหัส 653450279-6");
