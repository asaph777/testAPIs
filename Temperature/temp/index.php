<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Temperature Testing</title>
</head>
<body>
<div class="parse">
	<select id="city">
	<option></option>
	<option>Душанбе</option>
	<option>Хуҷанд</option>
	</select>
    
	<button>zer</button>
	<div class="error"></div>
	<div class="results"></div>
</div>

</body>
<script src = "jquery-3.6.0.js"></script>
<script>
var elem = document.querySelector('#city');
var btn = document.querySelector('button');
var err = document.querySelector('.error');
var res = document.querySelector('.results');

btn.addEventListener("click",()=>{
	res.textContent = "";
	err.textContent = "";
	if(elem.value){
		var requestOptions = {
		  method: 'GET',
		  redirect: 'follow'
		};
		
		try{
			fetch("http://localhost:5094/temp/"+elem.value, requestOptions)
			  .then(response => response.text())
			  .then(result => {
				  var json = JSON.parse(result);
				  var count = 0;
				  for(var obj in json){
					  ++count;
				  }
				  
				  var h3 = document.createElement("h3");
					  h3.classList.add('city');
					  h3.textContent = elem.value;
					  res.appendChild(h3);
					  
				  for(var i=0; i < count;i++){
					  var div = document.createElement('div');
					  
					  var date = document.createElement('div');
					  date.classList.add("date-"+i+1)
					  date.textContent = "Санаи: "+ json[i]['date'];
					  div.appendChild(date);											  
					  
					  var morning = document.createElement('div');
					  morning.classList.add("morning-"+i)
					  morning.textContent = "Пагарӯз: "+json[i]['morning'];
					  div.appendChild(morning);
					  
					  var day = document.createElement('div');
					  day.classList.add("day-"+i+1)
					  day.textContent = "Обед: "+json[i]['day'];
					  div.appendChild(day);
					  
					  var evening = document.createElement('div');
					  evening.classList.add("evening-"+i+1)
					  evening.textContent = "Шаб: "+json[i]['evening'];
					  div.appendChild(evening);
					  div.appendChild(document.createElement("br"));
					  
					  res.appendChild(div);
				  }
				  elem.value="";
			  })
			  .catch(error => err.textContent = error);
			  
		}catch(e)
		{
			err.textContent = "Error";
		}
	}else{
		err.textContent = "Select city";
	}
});

/*

*/
</script>
</html>
