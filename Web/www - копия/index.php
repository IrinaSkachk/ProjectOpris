<?php include "connect.php"; ?>
<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title>Электронная регистратура</title>
    <link rel="stylesheet" href="indexstyle.css">
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
 
 <div class="content ">
    <?php
    if(!empty($_SESSION['LoggedIn']) && !empty($_SESSION['login']))  
	{   // даём доступ пользователю к главной странице
		?>  
		
		<p>Здравствуйте, <b><?=$_SESSION['login']?></b>. <br>Сейчас вы можете записаться на прием. </br></p>
		<p><a href="logout.php">Выход</a></p> 
		<?php  
	}    
	elseif(!empty($_POST['username']) && !empty($_POST['password']))  
	{   // позволим пользователю войти на сайт 
		$username = $_POST["username"];  
		//$password = md5(mysqli_real_escape_string($_POST['password']));  
		$password = $_POST['password'];
		
		$sql = "SELECT * FROM account WHERE login = '".$username."' AND password = '".$password."'";
		$checklogin = mysqli_query($link, $sql);  
		
		if(mysqli_num_rows($checklogin) == 1)  
		{   
			$row = mysqli_fetch_array($checklogin);  
			$email = $row['email'];  
 
			$_SESSION['login'] = $username;  		
			$_SESSION['LoggedIn'] = 1;  
			$_SESSION['ID'] = $row['ID_Account'];  
			 
			echo "<p>Сейчас вы будете перенаправлены в свой аккаунт.</p>";  
			echo "<meta http-equiv='refresh' content='2;index.php'>";  
		}  
		else  
		{   echo "<h1>Ошибка!!!</h1>";  
			echo "<p>Мы не нашли такого аккаунта. <br><a href=\"index.php\"> Попробуйте ещё раз </a> или <a href=\"register.php\"> зарегистрируйтесь</a>.</br></p>";  
		} 
	}  
	else  
	{   // выводим форму для авторизации  
		?> 
		<div class="content block-1">
		<form method="post" action="index.php" name="loginform" id="loginform"> 
		<p align='center'>Войдите или <a href="register.php">зарегистрируйтесь</a>.</p> 
		<fieldset>  
			<label for="username">Логин</label><input type="text" name="username" id="username"><br>  
			<label for="password">Пароль</label><input type="password" name="password" id="password"><br>  
			<button type="submit" name="login" id="login">  Вход </button>
		</fieldset> 
		</form>  
       </div>  
		<?php  
	}  ?>
    </div>
    <div class="content block-2">
            <ul class="info">
                <li>Услуга является бесплатной.</li>
                <li>Запись к врачу производится на ближайшую неделю. </li>
                <li>Обновление расписания приемов врачей на сайте происходит ежедневно в 21:00.</li>
                <li>Услуга предназначена для записи пациентов на ПЛАНОВЫЙ прием к врачам. </li>
            </ul>
 </div>
   </div>
</body>
</html>