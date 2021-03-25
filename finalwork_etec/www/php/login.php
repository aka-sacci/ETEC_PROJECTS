<?php

include "dados_conexao.php";
	
$login = $_POST['username'];
	$senha = $_POST['password'];


try {

		$conection = mysqli_connect("localhost", "root", "" , "banco_tcc_doacao_novo");
        
		$data = mysqli_query($conection, "select * from tb08_user where tb08_id=$login and tb08_senha = '$senha'");
        $row_cnt = 0;
		$row_cnt = mysqli_num_rows($data);
		if($row_cnt == 1){
            while($row = mysqli_fetch_assoc($data)) {
               echo "tb08_nome: " . $row["tb08_nome"]. "<br>";
            
            }
        }else{
            
            echo('n');
        }
    
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}

?>