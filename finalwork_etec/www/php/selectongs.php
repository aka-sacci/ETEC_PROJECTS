<?php


header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
        $conecta->exec("set names utf8");
		$consulta = $conecta->prepare('select * from tb01_ongs');
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb01_nome":"' . $registro['tb01_nome']  . '",';
			$StringJson .= '"tb01_endereco":"' . $registro['tb01_endereco']  . '",';				
			$StringJson .= '"tb01_bairro":"' . $registro['tb01_bairro']  . '",';				
			$StringJson .= '"tb01_telefone":"' . $registro['tb01_telefone']  . '",';				
			$StringJson .= '"tb01_cnpj":"' . $registro['tb01_cnpj']  . '",';				
			$StringJson .= '"tb01_email":"' . $registro['tb01_email'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>