# NovaLoja2

$.blockUI();
$.blockUI({ message: '<h1><img src="busy.gif" /> Just a moment...</h1>' });
$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
http://malsup.com/jquery/block/
