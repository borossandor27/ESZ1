<?php
namespace classes;
class Kutya extends Allat{
//    public  $hang = "vau..vau";
    
    public function __construct() {
        parent::__construct();
        parent::$hang = "vau..vau";
        echo 'nevter: - '.__NAMESPACE__." - ";
    }
}
