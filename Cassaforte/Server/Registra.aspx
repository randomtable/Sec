<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registra.aspx.vb" Inherits="Registra" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
      <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <title>Cassaforte</title>
      
      <style>
      .bg-italia {color:#fff !important; background-color:#009688 !important}
          .btn-italia {color:#fff !important; background-color:#009688 !important}
          .bg-tertiary {color:#000 !important; background-color:#cddc39 !important}
          .btn-tertiary {color:#000 !important; background-color:#cddc39 !important}
          .bg-quaternary {color:#fff !important; background-color:#9c27b0 !important}
          .btn-quaternary {color:#fff !important; background-color:#9c27b0 !important}
          .bg-primary {color:#fff !important; background-color:#0066cc !important}
          .btn-primary {color:#fff !important; background-color:#0066cc !important}
          .bg-secondary {color:#fff !important; background-color:#656667 !important}
          .btn-secondary {color:#fff !important; background-color:#656667 !important}
          .bg-success {color:#fff !important; background-color:#44cc00 !important}
          .btn-success {color:#fff !important; background-color:#44cc00 !important}
          .bg-danger {color:#fff !important; background-color:#cc0000 !important}
          .btn-danger {color:#fff !important; background-color:#cc0000 !important}
          .bg-warning {color:#fff !important; background-color:#ccaa00 !important}
          .btn-warning {color:#fff !important; background-color:#ccaa00 !important}

          
          
.bg-100 {color:#000 !important; background-color:#dfe5e8 !important}
.bg-200 {color:#000 !important; background-color:#becbd2 !important}
.bg-300 {color:#000 !important; background-color:#9eb1bb !important}
.bg-400 {color:#fff !important; background-color:#7d97a5 !important}
.bg-500 {color:#fff !important; background-color:#57707d !important}
.bg-600 {color:#fff !important; background-color:#4d636f !important}
.bg-700 {color:#fff !important; background-color:#435761 !important}
.bg-800 {color:#fff !important; background-color:#3a4b53 !important}
.bg-900 {color:#fff !important; background-color:#303e45 !important}

      </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <header class="bg-primary">
      <div class="container text-white pt-4 pb-4">
        <h1>Cassaforte</h1>
        <p class="m-0 ml-1">Il tuo mondo.</p>
        <p class="m-0 ml-1">Al sicuro.</p>
      </div>
    </header>

    <div class="container">
      <section>

      <br />

      <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Registra Amministratore</h5>
            <div class="row">
              
              <div style="float:none; margin-left:auto; margin-right:auto; text-align:center;">
              <p>Questa maschera ti permette di registrare un Amministratore.</p>
              </div>

            </div>

            <div class="row">
    <div class="col">

    <p>Inserisci indirizzo e-mail e password per la registrazione:</p>

    </div>
    </div>

    <div class="row">
    <div class="col">

    <div class="col input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="basic-addon1">Email</span>
                    </div>
                    <input type="text" class="form-control" placeholder="Inserisci qui il tuo indirizzo email" aria-label="Email" aria-describedby="basic-addon1">
                  </div>

    </div>
    </div>

    <div class="row">
    <div class="col">

    <div class="col input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="Span1">Password</span>
                    </div>
                    <input type="password" class="form-control" placeholder="Inserisci qui la tua Password" aria-label="Username" aria-describedby="basic-addon1">
                  </div>

    </div>
    </div>

    <div class="row">
    <div class="col">

    <div style="float:none; margin-left:auto; margin-right:auto; text-align:center;">
    <button style="width: 300px;" type="button" class="btn mb-1 btn-primary">Registrati</button>
    </div>

    </div>
    </div>

          </div>
        </div>

      </section>
      </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
      
      <script>
          $(function () {
              $('[data-toggle="tooltip"]').tooltip()
          })
      </script>
      
      <script>
          $(function () {
              $('[data-toggle="popover"]').popover()
          })
      </script>
    </div>
    </form>
</body>
</html>
