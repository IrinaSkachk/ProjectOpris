<?php include "connect.php"; ?>
<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title>Электронная регистратура</title>
    <link rel="stylesheet" href="recstyle.css">
    <script type="text/javascript" src="jquery-1.11.3.min.js"></script>
    <script type="text/javascript" src="script.js"></script>
</head>
<body> 
 <div class="wrapper">
	<div class="main-head">
        <div class="main-head__logo">
            <img src="img/logo1.png" alt="logo"/>
        </div> 
    </div>
    <div class="login"> <p>Здравствуйте, <b><?=$_SESSION['login']?></b>. <a href="logout.php">Выход</a></p> </div>
    <div class="main-page__line1">
         <div class="main-menu">
            <a href="/index.php" class='b-link b-link_menu' >ГЛАВНАЯ</a>
            <a href="/record.php" class='b-link b-link_menu' >ЗАПИСАТЬСЯ НА ПРИЕМ</a>
            <a href="/recepts.php" class='b-link b-link_menu'>ИСТОРИЯ ПРИЕМОВ</a>
            <a href="/forum.php" class='b-link b-link_menu'>ФОРУМ</a>
        </div>  
    </div>
 
<div class="content">
		<?php
		if(!empty($_SESSION['LoggedIn']))  
		{   // даём доступ пользователю к записи
			?>  
			<?php  
			if(empty($_GET['clinic']))
			{	
				echo "<p align='center'><b>ВЫБЕРИТЕ ПОДХОДЯЩУЮ КЛИНИКУ</b></p>"; 
				$sql = "SELECT Name, Address, ID_Clinic FROM clinic";
				$clinics = mysqli_query($link, $sql);
				echo "<table>";
				while($row = mysqli_fetch_array($clinics))
				{
					echo "<tr><td><p><a href=\"record.php?clinic=".$row['ID_Clinic']."\">     ".$row['Name']." , ".$row['Address']."</a></p></td></tr>";
				}
			}
			else
			{
				if(empty($_GET['specialization']))
				{	
					$sql = "SELECT DISTINCT Specialization.Name, Specialization.ID_Specialization 
							FROM Specialization, 	(
														SELECT Doctor.ID_Specialization
														FROM Doctor, Clinic
														WHERE Doctor.ID_Clinic = ".$_GET['clinic']."
													) e
							WHERE Specialization.ID_Specialization = e.ID_Specialization
							ORDER BY Specialization.Name";
					$specializations = mysqli_query($link, $sql);
					if (mysqli_num_rows($specializations) <> 0)
					{
						echo "<p align='center'><b>ВЫБЕРИТЕ НУЖНОГО СПЕЦИАЛИСТА</b></p> ";
						echo "<table>";
						while($row = mysqli_fetch_array($specializations))
						{
					        echo "<tr><td><p><a href=\"record.php?clinic=".$_GET['clinic']."&specialization=".$row['ID_Specialization']."\">     ".$row['Name']."</a></p></tr></td>";
				        }
					}
					else
					{
						echo "<p><b>А нету ничего</b></p>";
					}
				}
				else
				{
					if(empty($_GET['doctor']))
					{	
						echo "<p align='center'><b>ВЫБЕРИТЕ ВРАЧА</b></p> ";
						$sql = "SELECT DISTINCT ID_Doctor, Surname, Doctor.Name, Patro 
							FROM Doctor, Specialization, Clinic
							WHERE (DOCTOR.ID_Specialization = ".$_GET['specialization'].") and (DOCTOR.ID_Clinic = ".$_GET['clinic'].")
							ORDER BY Surname";
						$doctors = mysqli_query($link, $sql);
						echo "<table>";
						while($row = mysqli_fetch_array($doctors))
						{
					        echo "<tr><td><p><a href=\"record.php?clinic=".$_GET['clinic']."&specialization=".$_GET['specialization']."&doctor=".$row['ID_Doctor']."\">     ".$row['Surname']." ".$row['Name']." ".$row['Patro']."</a></p> </tr></td>";
				        }
					}
					else
					{
						if (!empty($_GET['date']) and !empty($_GET['time']))
						{
							$sql = "SELECT *
									FROM Doctor
									WHERE (Doctor.ID_Doctor = ".$_GET['doctor'].")";
							$toDoctor = mysqli_query($link, $sql);
							$rowDoctor = mysqli_fetch_array($toDoctor);
							
							$sql = "SELECT Name
									FROM Specialization
									WHERE Specialization.ID_Specialization = ".$_GET['specialization']."";
							$toSpec = mysqli_query($link, $sql);
							$rowSpec = mysqli_fetch_array($toSpec);
							
							$sql = "SELECT *
									FROM Clinic
									WHERE (Clinic.ID_Clinic = ".$_GET['clinic'].")";
							$toClinic = mysqli_query($link, $sql);
							$rowClinic = mysqli_fetch_array($toClinic);
							
							echo "<p align='center'><b>ВЫ УСПЕШНО ЗАПИСАНЫ</b></p>";
							echo "<p align='center'>".$rowClinic[Name]." - ".$rowClinic[Address]."</p>";
							echo "<p align='center'>".$rowDoctor[Surname]." ".$rowDoctor[Name]." ".$rowDoctor[Patro]." - ".$rowSpec[Name]."</p>";
							echo "<p align='center'>".$_GET[date]." - ".$_GET[time]."</p>";
							$sql = "INSERT INTO General (ID_Account, ID_Doctor, Date, Time) 
									VALUES (".$_SESSION['ID'].", ".$_GET['doctor'].", \"".$_GET['date']."\", \"".$_GET['time'].":00\")";
							//var_dump($sql);
							$insertRecept = mysqli_query($link, $sql);
						}
						else
						{
							$sqlStart = "SELECT *
										FROM StartRecept, Doctor
										WHERE (Doctor.ID_Doctor = ".$_GET['doctor'].") and (Doctor.ID_StartRecept = StartRecept.ID_StartRecept)";
							var_dump($sqlStart);
							$time = mysqli_query($link, $sqlStart);
							$timeStart = mysqli_fetch_array($time);
							$sqlStop = "SELECT *
										FROM EndRecept, Doctor
										WHERE (Doctor.ID_Doctor = ".$_GET['doctor'].") and (Doctor.ID_EndRecept = EndRecept.ID_EndRecept)";
							$time = mysqli_query($link, $sqlStop);
							$timeStop = mysqli_fetch_array($time);		
							?>
							<table class="time">
								<thead>
								<tr>
									<?php
									$recepts = 0;
										
									for ($i=0; $i<=6; $i++)
									{
										echo "<th>";
										$d = strtotime("+".$i."day");
										echo date("l d.m.Y", $d);   
										echo "</th>";
										
										$day = date("l", $d);
										$diff = strtotime($timeStop[$day]) - strtotime($timeStart[$day]);
										$diff = $diff/1800;
										
										if ($diff > $recepts)
										{
											$recepts = $diff;
										};
									}
									$recepts--;
									?>
								</tr>
								</thead>
							<tbody>
								<?php
								for ($i=0; $i<=$recepts; $i++)
								{
									echo "<tr>";
									for ($j=0; $j<=6; $j++)
									{
										$d = strtotime("+".$j."day");
										$day = date("l", $d);
										
										$start = strtotime($timeStart[$day]);
										$start = $start + $i * 30 * 60;
										$start = date('H:i', $start);
										$stop = strtotime($timeStart[$day]);
										$stop = $stop + ($i + 1) * 30 * 60;
										$stop = date('H:i', $stop); 
										
										
										if ((strtotime($timeStop[$day]) >= strtotime($stop))) //выводим что есть
										{
											$Ymd = date("Y-m-d",$d);
											$sql = "SELECT Time
													FROM General
													WHERE (General.ID_Doctor = ".$_GET['doctor'].") and (General.Date = \"".$Ymd."\")";
											$checkRecept = mysqli_query($link, $sql);
											$times = array();
											while($row = mysqli_fetch_array($checkRecept))
											{
												$times[] = date('H:i', strtotime($row['Time']));
											}	
											//$row = mysqli_fetch_array($checkRecept);
											
											if ((mysqli_num_rows($checkRecept) > 0) and (in_array($start, $times))) //смотрим есть ли запись на время
											{
												$outtext = $start;
												$color = "bgcolor=\"#e70000\""; //red
											}
											else
											{
												$outtext = "<p><a href=\"record.php?clinic=".$_GET['clinic']."&specialization=".$_GET['specialization']."&doctor=".$_GET['doctor']."&date=".$Ymd."&time=".$start."\">     ".$start."</a></p>";
												$color = "bgcolor=\"#21e103\""; //green
											}	
											
											echo "<td ".$color.">";
												echo $outtext;
											echo "</td>";
										}
										else
										{
											echo "<td></td>";
										}
									}
									echo "</tr>";
								}
								?>
							</tbody>
							</table>
							<?php
						}
					}
				}
			}
		}
		else
		{
			?>
			<p>Для записи к врачу вам необходимо <a class="enter" href="index.php">войти</a> или <a class="enter" href="register.php">зарегистрироваться!</a></p> 
			<?php
		}
		?>
	</div>
 </div>
</body>
</html>