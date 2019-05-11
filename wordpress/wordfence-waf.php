<?php
// Before removing this file, please verify the PHP ini setting `auto_prepend_file` does not point to this.

if (file_exists('C:\\xampp\\htdocs\\wp-content\\plugins\\wordfence/waf/bootstrap.php')) {
	define("WFWAF_LOG_PATH", 'C:\\xampp\\htdocs/wp-content/wflogs/');
    include_once 'C:\\xampp\\htdocs\\waf.php';
	include_once 'C:\\xampp\\htdocs\\wp-content\\plugins\\wordfence/waf/bootstrap.php';
}
?>