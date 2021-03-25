<?php

include "dados_conexao.php";
	
$telefone = $_POST['tel'];
	$senha = $_POST['password'];
	$nome = $_POST['nome'];
	$email = $_POST['email'];

		$conection = mysqli_connect("localhost", "root", "" , "banco_tcc_doacao_novo");
		$sql = "insert into tb08_user(tb08_id, tb08_senha, tb08_nome, tb08_email) values('$telefone', '$senha', '$nome', '$email')";
        $result = mysqli_query($conection, $sql);
		$data = mysqli_query($conection, "select * from tb08_user where tb08_id=$telefone and tb08_senha = '$senha'");
        $row_cnt = 0;
		$row_cnt = mysqli_num_rows($data);
		if($row_cnt == 1){
            
            echo('s');
        }else{
            
            echo('n');
        }
        
		
?>