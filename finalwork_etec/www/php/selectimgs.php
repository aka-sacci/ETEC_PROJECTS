<?php


header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

        $ong = $_GET['ong'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select * from tb12_imagens where tb12_ong = $ong order by tb12_data_upload DESC");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb12_seq":"' . $registro['tb12_seq']  . '",';			
			$StringJson .= '"tb12_extencao":"' . $registro['tb12_extencao']  . '",';			
			$StringJson .= '"tb12_data_upload":"' . $registro['tb12_data_upload']  . '",';					
			$StringJson .= '"tb12_descricao":"' . $registro['tb12_descricao'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>