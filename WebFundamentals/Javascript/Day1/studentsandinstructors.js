function st(){
var students = [
     {first_name :  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
];
    for(var x in students)
    {
        console.log(students[x].first_name, students[x].last_name);
    }
}
st();


//bonus
var users = {
 'Students': [
     {first_name:  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
  ],
 'Instructors': [
     {first_name : 'Michael', last_name : 'Choi'},
     {first_name : 'Martin', last_name : 'Puryear'}
  ]
 };
 function name(){

     for(var x in users)
    {
        console.log(x);
        for(var i = 0; i < users[x].length; i++)
      {
          console.log(i + 1 + " - " + users[x][i].first_name + " " + users[x][i].last_name + " - " + (users[x][i].first_name.length + users[x][i].last_name.length));
      }
    }
 }
name();
