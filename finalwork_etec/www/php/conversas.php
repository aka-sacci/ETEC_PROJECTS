<?php


header("Access-Control-Allow-Origin: *");


include('dados_conexao.php');

try {

        $ong = $_GET['ong'];
        $user = $_GET['user'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
        $conecta->exec("set names utf8");
		$consulta = $conecta->prepare("select tb05_mensagem, tb08_nome, tb05_data, tb08_id from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_para = $ong and tb08_id = $user or tb05_para = $user and tb08_id = $ong order by tb05_data desc)";
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[" {$StringJson .= ",";
			$StringJson .= '{"tb05_mensagem":"' . $registro['tb05_mensagem']  . '",';			
			$StringJson .= '"tb05_data":"' . $registro['tb05_data']  . '",';			
			$StringJson .= '"tb08_id":"' . $registro['tb08_id']  . '",';			
			$StringJson .= '"tb08_nome":"' . $registro['tb08_nome']  . '"}';					
			
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>