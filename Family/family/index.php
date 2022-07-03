<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Family Tree Testing</title>
</head>
<body>
<div class="parse">
<select id="name">
	<option></option>
</select>
<label>
<input type="radio" name="param" value="1" id="">Предки
</label>
<label>
<input type="radio" name="param" value="2" id="">Потомки
</label>


<br>
<button>zer</button>
<div class="errors"></div>
<div class="results"></div>
</div>

</body>

<script>
var err = document.querySelector('.error');
var requestOptions = {
  method: 'GET',
  redirect: 'follow'
};

fetch("http://localhost:5191/all", requestOptions)
  .then(response => response.text())
  .then(result => {
	  var json = JSON.parse(result);
	  var count = 0;
	  for(var obj in json){
		  ++count;
	  }
	  for(var i =0; i < count; i++){
		  var opt = document.createElement('option');
		  opt.value = json[i].id;
		  opt.textContent = json[i].name;
		  elem.appendChild(opt);
	  }
  	})
  .catch(error => err.textContent = +"error: "+ error);

</script>

<script>
var elem = document.querySelector('#name');
var btn = document.querySelector('button');
var err = document.querySelector('.errors');
var res = document.querySelector('.results');
var radios = document.querySelectorAll("[name='param']");
var param = 0;

btn.addEventListener("click",()=>{
	res.textContent = "";
	if(elem.value){
		var requestOptions = {
		  method: 'GET',
		  redirect: 'follow'
		};
		if(radios[0].checked){
			param = radios[0].value;
		}else if(radios[1].checked){
			param = radios[1].value;
		}else{
			err.textContent = "Select one of radios!!!";
			return;
		}
		try{
			fetch("http://localhost:5191/"+param+"/"+elem.value, requestOptions)
			.then(response => response.text())
			.then(result => {
				var json = JSON.parse(result);
				var count = 0;
				for(var obj in json){
					++count;
				}
				if(count == 0){
					res.textContent = "Ёфт нашуд";
					return;
				}
				var ul = document.createElement('ol');				
					for(var i = 0; i < count; i++){
						var li = document.createElement('li');											
						li.textContent = "Ном: " + json[i].name + "-- Cанаи таваллуд: " + json[i].dateBirth;							
						ul.appendChild(li);
					}
					res.appendChild(ul);				
			})
			.catch(error => err.textContent = error);
		}catch(e){
			err.textContent = "Error";
		}
	}else{
		err.textContent = "Select one of Persons!!!";
	}
})
</script>
</html>
