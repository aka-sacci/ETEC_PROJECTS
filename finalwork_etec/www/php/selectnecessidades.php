<?php


header("Access-Control-Allow-Origin: *");


include('dados_conexao.php');

try {

        $ong = $_GET['ong'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
    $conecta->exec("set names utf8");
		$consulta = $conecta->prepare("select tb03_tipo, tb06_ong from tb06_tipos inner join tb03_tipo_doacao on tb06_tipos.tb06_tipo = tb03_tipo_doacao.tb03_cod where tb06_ong = $ong");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb03_tipo":"' . $registro['tb03_tipo']  . '",';			
			$StringJson .= '"tb06_ong":"' . $registro['tb06_ong'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>