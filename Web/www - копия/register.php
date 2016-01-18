<?php include "connect.php"; ?> 
<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title>Регистрация пользователей</title>
    <link rel="stylesheet" href="regstyle.css" >
</head>
<body>
 <div class="wrapper">
	<div class="main-head">
        <div class="main-head__logo">
            <img src="img/logo1.png" alt="logo"/>
        </div> 
    </div>
    <div class="main-page__line1">
         <div class="main-menu">
            <a href="/index.php" class='b-link b-link_menu' >ГЛАВНАЯ</a>
            <a href="/record.php" class='b-link b-link_menu' >ЗАПИСАТЬСЯ НА ПРИЕМ</a>
            <a href="/recepts.php" class='b-link b-link_menu'>ИСТОРИЯ ПРИЕМОВ</a>
            <a href="/forum.php" class='b-link b-link_menu'>ФОРУМ</a>
        </div>  
    </div>
    <div id="main">
    <?php
    if(!empty($_POST['username']) && !empty($_POST['password']))  
    {   // позволим пользователю зарегистрироваться
		//$username = mysqli_real_escape_string($_POST['username']);  
		//$password = md5(mysqli_real_escape_string($_POST['password']));  
		//$email = mysqli_real_escape_string($_POST['email']);  
		
		$username = $_POST['username'];  
		$password = $_POST['password'];  
		$email = $_POST['email']; 
		$name = $_POST['name'];
		$surname = $_POST['surname'];
		$patro = $_POST['patro'];
		$address = $_POST['address'];
		$DateOfBirth = $_POST['DateOfBirth'];
		$InsurancePolicy = $_POST['InsurancePolicy'];
		
		$sql = "SELECT * FROM account WHERE login = '".$username."'";
		$checkusername = mysqli_query($link, $sql);  
			
		if(mysql_num_rows($checkusername) == 1)  
		{  
			echo "<h1>Ошибка</h1>";  
			echo "<p>Извините, такое имя пользователя уже используется. Вернитесь назад и попробуйте снова.</p>";  
		}  
		else  
		{  	
			$sql = "INSERT INTO account (login, password, email, name, surname, patro, address, DateOfBirth, InsurancePolicy) VALUES('".$username."', '".$password."', '".$email."', 
				'".$name."', '".$surname."', '".$patro."', '".$address."', '".$DateOfBirth."', '".$InsurancePolicy."')";
			$registerquery = mysqli_query($link, $sql);
			
			if($registerquery)  
			{  
	 
				echo "<p>Ваша учётная запись создана. <a href=\"index.php\">Авторизуйтесь</a>.</p>";  
			}  
			else  
			{  
				echo "<h1>Ошибка</h1>";  
				echo "<p>Мы не смогли вас зарегистрировать. Вернитесь назад и попробуйте снова.</p>";      
			}         
		}  
	}  
	else  
	{  
		?>  
		<form method="post" action="register.php" name="registerform" id="registerform"> 
		<h1 align='center'>РЕГИСТРАЦИЯ</h1>  
		<p align='center'>Пожалуйста, заполните поля для регистрации.</p> 
		<fieldset>  
			<label for="username">Логин</label><input type="text" name="username" id="username"><br>  
			<label for="password">Пароль</label><input type="password" name="password" id="password"><br>  
			<label for="email">E-mail</label><input type="text" name="email" id="email"><br>
			<label for="name">Имя</label><input type="text" name="name" id="name"><br>
			<label for="surname">Фамилия</label><input type="text" name="surname" id="surname"><br>
			<label for="patro">Отчество</label><input type="text" name="patro" id="patro"><br>
			<label for="address">Адрес</label><input type="text" name="address" id="address"><br>
			<label for="DateOfBirth">Дата рождения (год-месяц-число)</label><input type="text" name="DateOfBirth" id="DateOfBirth"><br>
			<label for="InsurancePolicy">№ ОМС</label><input type="text" name="InsurancePolicy" id="InsurancePolicy"><br>
			<button type="submit" name="register" id="register"> Зарегистрироваться </button>
		</fieldset>  
		</form>  

		<?php  
	}  	?>
    </div>
</body>
</html>