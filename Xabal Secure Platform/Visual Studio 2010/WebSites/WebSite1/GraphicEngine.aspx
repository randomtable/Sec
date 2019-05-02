﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GraphicEngine.aspx.vb" Inherits="_GraphicEngine" ViewStateEncryptionMode="Always" WarningLevel="4" ViewStateMode="Enabled" ValidateRequest="True" Transaction="Required" Trace="False" Strict="True" MaintainScrollPositionOnPostback="False" LinePragmas="True" EnableViewStateMac="True" EnableViewState="True" EnableTheming="True" EnableSessionState="True" EnableEventValidation="True" Debug="True" CompilationMode="Always" Buffer="True" Async="False" AspCompat="True" Explicit="True" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<base  href="http://localhost:56114/WebSite1/" />
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
      <link rel="stylesheet" href="css/Lorem.css">

    <title>Hello, world!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div class="cookiebar bg-dark p-4 hide" aria-hidden="true">
        <p class="text-white">Questo sito utilizza cookie tecnici, analytics e di terze parti.
            <br>Proseguendo nella navigazione accetti l’utilizzo dei cookie.<br>
        </p>
        <p>
            <button data-accept="cookiebar" style="height:50px;" class="waves-effect waves-light btn btn-info mr-2">Accetto</button>
            <a href="" style="height:50px;" class="waves-effect waves-light btn btn-outline-info">Privacy policy</a>
        </p>
    </div>

    <header class="bg-primary">
      <div class="container text-white pt-4 pb-4">
        <h1 class="display-1 display-1 mb-0">Lorem Framework Kitchen Sink</h1>
        <p class="m-0 ml-1">Visualizza quasi tutti i componenti di Lorem Framework in una singola pagina.</p>
        <p class="ml-1 mb-3">Particolarmente utile per la personalizzazione del tema grafico e la creazione di nuove pagine.</p>
      </div>
    </header>
      
      <ul id="slide-out" class="sidenavM bg-primary">
    <li><div class="user-view">
      <div class="background">
        <img src="img/1.jpg">
      </div>
      <a href="#user"><img class="circle" src="img/2.jpg"></a>
      <a href="#name"><span class="white-text name">Alessandro Fiori</span></a>
      <a href="#email"><span class="white-text email"><span class="__cf_email__" data-cfemail="20414c4546494f52491360474d41494c0e434f4d">[email&#160;protected]</span></span></a>
    </div></li>
    <li><a href="#!"><i class="material-icons">cloud</i>First Link With Icon</a></li>
    <li><a href="#!">Second Link</a></li>
    <li><div class="divider"></div></li>
    <li><a class="subheader">Subheader</a></li>
    <li><a class="waves-effect" href="#!">Third Link With Waves</a></li>
          <li><a class="nav-item nav-link text-white pl-3 pr-3 mr-3 border border-white" href="#tipografia">Tipografia</a></li>
            <li><a class="nav-item nav-link text-white pl-3 pr-3 mr-3 border border-white" href="#tabelle">Tabelle</a></li>
            <li><a class="nav-item nav-link text-white pl-3 pr-3 mr-3 border border-white" href="#griglie">Griglie</a></li>
            <li><a class="nav-item nav-link text-white pl-3 pr-3 mr-3 border border-white" href="#form">Elementi Form</a></li>
            <li><a class="nav-item nav-link text-white pl-3 pr-3 mr-3 border border-white" href="#componenti">Componenti</a></li>
  </ul>

    <div class="container">
        
        <a href="#" data-target="slide-out" class="sidenavM-trigger"><i class="material-icons">menu</i></a>

        <br />

        <asp:Button ID="Button1" runat="server" Text="Go to Application" class="btn mb-1 btn-primary" style="height:50px;" />
        
      <section>
        <h2 id="tipografia" class="pt-5 pb-3">Tipografia</h2>
        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Colori</h5>
            <div class="row">
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-italia text-white">italia</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-primary text-white">primary</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-secondary text-dark">secondary</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-tertiary text-white">tertiary</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-quaternary text-dark">quaternary</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-success text-white">success</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-danger text-white">danger</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-warning text-dark">warning</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-white text-dark">white</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-100 text-dark">100</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-200 text-dark">200</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-300 text-dark">300</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-400 text-white">400</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-500 text-white">500</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-600 text-white">600</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-700 text-white">700</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-800 text-white">800</div>
              <div class="pt-sm-4 pb-sm-4 text-center col-sm-2 bg-900 text-white">900</div>
            </div>
          </div>
        </div>

        <div class="card-deck">
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Intestazioni</h5>
              <div class="card-text">
                <h1>h1. Intestazione</h1>
                <h2>h2. Intestazione</h2>
                <h3>h3. Intestazione</h3>
                <h4>h4. Intestazione</h4>
                <h5>h5. Intestazione</h5>
                <h6>h6. Intestazione</h6>
              </div>
            </div>
          </div>
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Intestazioni in evidenza</h5>
              <div class="card-text">
                <h1 class="display-1">Titolo in evidenza 1</h1>
                <h1 class="display-2">Titolo in evidenza 2</h1>
                <h1 class="display-3">Titolo in evidenza 3</h1>
                <h1 class="display-4">Titolo in evidenza 4</h1>
              </div>
            </div>
          </div>
        </div>

        <div class="card-deck">
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Badge</h5>
              <div class="card-text">
                <h1>Titolo <span class="badge border border-primary">New</span></h1>
                <h2>Titolo <span class="badge border border-primary">New</span></h2>
                <h3>Titolo <span class="badge border border-primary">New</span></h3>
                <h4>Titolo <span class="badge border border-primary">New</span></h4>
                <h5>Titolo <span class="badge border border-primary">New</span></h5>
                <h6>Titolo <span class="badge border border-primary">New</span></h6>
              </div>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Elementi di testo inline</h5>
              <div class="card-text">
                <p>Elemento di un <mark>testo evidenziato</mark>.</p>
                <p><del>Elemento di un testo cancellato.</del></p>
                <p><s>Elemento di un testo non più valido.</s></p>
                <p><ins>Elemento di un testo aggiuntivo al documento.</ins></p>
                <p><u>Elemento di un testo sottolineato.</u></p>
                <p><small>Elemento di testo con "righe piccole".</small></p>
                <p><strong>Elemento di un testo grassetto.</strong></p>
                <p><em>Elemento di un testo corsivo.</em></p>
              </div>
            </div>
          </div>
        </div>

        <div class="card-deck">
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Liste senza stile</h5>
              <div class="card-text">
                <ul class="list-unstyled">
                  <li>Lorem ipsum dolor sit amet</li>
                  <li>Consectetur adipiscing elit</li>
                  <li>Nulla volutpat aliquam velit
                    <ul>
                      <li>Phasellus iaculis neque</li>
                      <li>Purus sodales ultricies</li>
                    </ul>
                  </li>
                  <li>Faucibus porta lacus fringilla vel</li>
                  <li>Eget porttitor lorem</li>
                </ul>
              </div>
            </div>
          </div>
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Liste inline</h5>
              <div class="card-text">
                <ul class="list-inline">
                  <li class="list-inline-item">Lorem ipsum</li>
                  <li class="list-inline-item">Phasellus iaculis</li>
                  <li class="list-inline-item">Nulla volutpat</li>
                  <li class="list-inline-item">Integer molestie lorem at massa</li>
                  <li class="list-inline-item">Facilisis in pretium nisl aliquet</li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section>
        <h2 id="tabelle" class="pt-5 pb-3">Tabelle</h2>
        <div class="card-deck">
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Predefinita</h5>
              <div class="table-responsive">
                <table class="table">
                  <thead>
                    <tr>
                      <th scope="col">#</th>
                      <th scope="col">Nome</th>
                      <th scope="col">Cognome</th>
                      <th scope="col">Username</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope="row">1</th>
                      <td>Mario</td>
                      <td>Verdi</td>
                      <td>mario.verdi</td>
                    </tr>
                    <tr>
                      <th scope="row">2</th>
                      <td>Francesco</td>
                      <td>Bianchi</td>
                      <td>francesco.bianchi</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td>Alessandro</td>
                      <td>Rossi</td>
                      <td>alessandro.rossi</td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Compatta</h5>
              <div class="table-responsive">
                <table class="table table-sm">
                  <thead>
                    <tr>
                      <th scope="col">#</th>
                      <th scope="col">Nome</th>
                      <th scope="col">Cognome</th>
                      <th scope="col">Username</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope="row">1</th>
                      <td>Mario</td>
                      <td>Verdi</td>
                      <td>mario.verdi</td>
                    </tr>
                    <tr>
                      <th scope="row">2</th>
                      <td>Francesco</td>
                      <td>Bianchi</td>
                      <td>francesco.bianchi</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td>Alessandro</td>
                      <td>Rossi</td>
                      <td>alessandro.rossi</td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>

        <div class="card-deck">
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Bordatura e hover</h5>
              <div class="table-responsive">
                <table class="table table-bordered table-hover">
                  <thead>
                    <tr>
                      <th scope="col">#</th>
                      <th scope="col">Nome</th>
                      <th scope="col">Cognome</th>
                      <th scope="col">Username</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope="row">1</th>
                      <td>Mario</td>
                      <td>Verdi</td>
                      <td>mario.verdi</td>
                    </tr>
                    <tr>
                      <th scope="row">2</th>
                      <td>Francesco</td>
                      <td>Bianchi</td>
                      <td>francesco.bianchi</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td>Alessandro</td>
                      <td>Rossi</td>
                      <td>alessandro.rossi</td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Righe alternate</h5>
              <div class="table-responsive">
                <table class="table table-striped">
                  <thead>
                    <tr>
                      <th scope="col">#</th>
                      <th scope="col">Nome</th>
                      <th scope="col">Cognome</th>
                      <th scope="col">Username</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <th scope="row">1</th>
                      <td>Mario</td>
                      <td>Verdi</td>
                      <td>mario.verdi</td>
                    </tr>
                    <tr>
                      <th scope="row">2</th>
                      <td>Francesco</td>
                      <td>Bianchi</td>
                      <td>francesco.bianchi</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td>Alessandro</td>
                      <td>Rossi</td>
                      <td>alessandro.rossi</td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </section>

      <section>
        <h2 id="griglie" class="pt-5 pb-3">Griglie</h2>
        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Adattamento automatico</h5>
            <div class="row bg-100 mb-1">
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
            </div>
            <div class="row mb-1">
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
            </div>
            <div class="row bg-100 mb-1">
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
            </div>
            <div class="row mb-1">
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
            </div>
            <div class="row bg-100 mb-1">
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
              <div class="col border text-center">
                .col
              </div>
            </div>
          </div>
        </div>

        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Adattamento prefissato</h5>
            <div class="row bg-100 mb-1">
              <div class="col-4 border text-center">
                .col-4
              </div>
              <div class="col-8 border text-center">
                .col-8
              </div>
            </div>
            <div class="row mb-1">
              <div class="col-2 border text-center">
                .col-2
              </div>
              <div class="col-4 border text-center">
                .col-4
              </div>
              <div class="col-4 border text-center">
                .col-4
              </div>
              <div class="col-2 border text-center">
                .col-2
              </div>
            </div>
            <div class="row bg-100 mb-1">
              <div class="col-2 border text-center">
                .col-2
              </div>
              <div class="col-10 border text-center">
                .col-10
              </div>
            </div>
            <div class="row mb-1">
              <div class="col-3 border text-center">
                .col-3
              </div>
              <div class="col-6 border text-center">
                .col-6
              </div>
              <div class="col-3 border text-center">
                .col-3
              </div>
            </div>

          </div>
        </div>



      </section>

      <section>
        <h2 id="form" class="pt-5 pb-3">Elementi Form</h2>
        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Elementi di base</h5>
            <form>
              <div class="row">
                <div class="form-group col-sm-6">
                  <input type="text" class="form-control" id="exampleInputText">
                  <label for="exampleInputText">Text</label>
                </div>
                <div class="form-group col-sm-6">
                  <input type="number" class="form-control" id="exampleInputNumber">
                  <label for="exampleInputNumber">Number</label>
                </div>
                <div class="form-group col-sm-6">
                  <input class="form-control" type="text" id="videoYoutube">
                  <label for="videoYoutube">Text con icona</label>
                </div>
                <div class="form-group col-sm-6">
                  <div class="input-group mb-3">
  <div class="input-group-prepend">
  </div>
  <select class="custom-select" id="inputGroupSelect01">
    <option selected>Choose...</option>
    <option value="1">One</option>
    <option value="2">Two</option>
    <option value="3">Three</option>
  </select>
</div>
                </div>

                <div class="form-groupM col-sm-6 form-file">
                  <input id="file" class="form-control" type="file">
                  <label for="file">Upload singolo file</label>
                  <span class="form-file-name mr-1 ml-1"></span>
                </div>
                <div class="form-groupM col-sm-6 form-file">
                  <input id="fileM" class="form-control" type="file" multiple="multiple">
                  <label for="fileM">Upload multiplo di file</label>
                  <span class="form-file-name mr-1 ml-1"></span>
                </div>

                <div class="form-group col-sm-6">
                  <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                  <label for="exampleFormControlTextarea1">Textarea</label>
                </div>

                <div class="form-group col-sm-6">
                    <input type="password" class="form-control" id="exampleInputPassword">
                    <label for="exampleInputPassword">Password</label>
                  </div>
                <div class="col-sm-6">
                  <div class="form-check form-check-inline">
                    <input id="checkbox3" type="checkbox" checked="checked">
                    <label for="checkbox3">Checkbox selezionato</label>
                  </div>
                  <div class="form-check form-check-inline">
                    <input id="checkbox2" type="checkbox">
                    <label for="checkbox2">Checkbox non selezionato</label>
                  </div>
                </div>
                <div class="col-sm-6">
                  <div class="form-check form-check-inline">
                    <input name="gruppo2" type="radio" id="radio4" checked>
                    <label for="radio4">Opzione 1</label>
                  </div>
                  <div class="form-check form-check-inline">
                    <input name="gruppo2" type="radio" id="radio5">
                    <label for="radio5">Opzione 2</label>
                  </div>
                </div>

                </div>
              </form>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Gruppi di elementi</h5>
              <form>
                <div class="row">
                  <div class="col-sm-6 input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="basic-addon1">@</span>
                    </div>
                    <input type="text" class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1">
                  </div>

                  <div class="col-sm-6 input-group pb-3">
                    <input type="text" class="form-control" placeholder="Mail utente" aria-label="Mail utente" aria-describedby="basic-addon2">
                    <div class="input-group-append">
                      <span class="input-group-text" id="basic-addon2">@esempio.it</span>
                    </div>
                  </div>

                  <div class="col-sm-6 input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text">€</span>
                    </div>
                    <input type="text" class="form-control" aria-label="Amount (to the nearest dollar)">
                    <div class="input-group-append">
                      <span class="input-group-text">,00</span>
                    </div>
                  </div>

                  <div class="col-sm-6 input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text" id="">Nominativo</span>
                    </div>
                    <input type="text" class="form-control" placeholder="Nome" aria-label="Nome">
                    <input type="text" class="form-control" placeholder="Cognome" aria-label="Cognome">
                  </div>
                  <div class="col-sm-6 input-group pb-3">
                    <div class="input-group-prepend">
                      <span class="input-group-text">Textarea</span>
                    </div>
                    <textarea class="form-control" aria-label="With textarea" rows="3"></textarea>
                  </div>

                  <div class="col-sm-6 form-group">
                    <div class="input-group pb-3">
                      <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon3">https://esempio.it/utente/</span>
                      </div>
                      <input type="text" class="form-control" id="basic-url" aria-describedby="basic-addon3">
                    </div>
                  </div>



                </div>
              </form>
            </div>
          </div>

        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Bottoni</h5>
              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-italia">Italia</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary">Primary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary">Secondary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-tertiary">Tertiary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-quaternary">Quaternary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-success">Success</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-danger">Danger</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-warning">Warning</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-link">Link</button>
              </div>

              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-italia active" aria-pressed="true">Italia</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary active" aria-pressed="true">Primary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary active" aria-pressed="true">Secondary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-tertiary active" aria-pressed="true">Tertiary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-quaternary active" aria-pressed="true">Quaternary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-success active" aria-pressed="true">Success</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-danger active" aria-pressed="true">Danger</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-warning active" aria-pressed="true">Warning</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-link">Link</button>
              </div>

              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-italia disabled">Italia</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary disabled">Primary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary disabled">Secondary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-tertiary disabled">Tertiary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-quaternary disabled">Quaternary</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-success disabled">Success</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-danger disabled">Danger</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-warning disabled">Warning</button>
              </div>

              <div class="row ml-0">
                <div class="dropdown mb-1 mr-1">
                  <button style="height:50px;" class="waves-effect waves-light btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Apri dropdown
                  </button>
                  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                    <h6 class="dropdown-header">Header 1</h6>
                    <a class="dropdown-item" href="#">Azione 1</a>
                    <a class="dropdown-item" href="#">Azione 2</a>
                    <a class="dropdown-item" href="#">Azione 3</a>
                    <div class="dropdown-divider"></div>
                    <h6 class="dropdown-header">Header 2</h6>
                    <a class="dropdown-item" href="#">Azone 4</a>
                  </div>
                </div>
                
                
              </div>

              <div class="dropdown mb-1 mr-1">
                <button style="height:50px;" class="waves-effect waves-light btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                  Dropdown full width
                </button>
                <div class="dropdown-menu full-width" aria-labelledby="dropdownMenuButton">
                    <a class="dropdown-item" href="#">Azione 1</a>
                    <a class="dropdown-item" href="#">Azione 2</a>
                    <a class="dropdown-item" href="#">Azione 3</a>
                </div>
              </div>




              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary btn-sm">Small button</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary btn-sm">Small button</button>
                <div style="height:50px;" class="waves-effect waves-light btn-group mb-1">
                  <button style="height:50px;" class="waves-effect waves-light btn btn-secondary btn-sm dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Small button
                  </button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="#">Azione 1</a>
                    <a class="dropdown-item" href="#">Azione 2</a>
                    <a class="dropdown-item" href="#">Azione 3</a>
                  </div>
                </div>
              </div>
              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary btn-lg">Large button</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary btn-lg">Large button</button>
                <div style="height:50px;" class="waves-effect waves-light btn-group mb-1">
                  <button style="height:50px;" class="waves-effect waves-light btn btn-secondary btn-lg dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Large button
                  </button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="#">Azione 1</a>
                    <a class="dropdown-item" href="#">Azione 2</a>
                    <a class="dropdown-item" href="#">Azione 3</a>
                  </div>
                </div>
              </div>
              <div>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-primary btn-lg btn-block">Block level button</button>
                <button type="button" style="height:50px;" class="waves-effect waves-light btn mb-1 btn-secondary btn-lg btn-block">Block level button</button>
              </div>
          </div>
        </div>


        <div class="card mb-3">
          <div class="card-body">
            <h5 class="card-title border-bottom border-italia">Alert</h5>
            <div class="alert alert-success alert-dismissible fade show" role="alert">
              <strong>Congratulazioni</strong> Questo è un alert di <em>success</em>!
              <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                  <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="alert alert-danger alert-dismissible fade show" role="alert">
              <strong>Attenzione</strong> Questo è un alert di <em>danger</em>!
              <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="alert alert-warning alert-dismissible fade show" role="alert">
              <strong>Attenzione</strong> Questo è un alert di <em>warning</em>!
              <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
          </div>
        </div>

      </section>



        <section>
          <h2 id="componenti" class="pt-5 pb-3">Componenti</h2>

          <div class="card-deck">
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Breadcrumb</h5>
                <nav aria-label="breadcrumb">
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="#">Home</a></li>
                    <li class="breadcrumb-item"><a href="#">Library</a></li>
                    <li class="breadcrumb-item active" aria-current="page">Data</li>
                  </ol>
                </nav>
              </div>
            </div>

            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Barre di avanzamento</h5>
                <div class="progress mb-2">
                  <div class="progress-bar" role="progressbar" style="width: 25%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
                <div class="progress mb-2">
                  <div class="progress-bar" role="progressbar" style="width: 50%;" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
                <div class="progress mb-2">
                  <div class="progress-bar" role="progressbar" style="width: 100%;" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
              </div>
            </div>
          </div>

          <div class="card-deck">
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Paginazione</h5>
                
                  <div class="pagination">
  <a href="#">&laquo;</a>
  <a href="#">1</a>
  <a href="#" class="active">2</a>
  <a href="#">3</a>
  <a href="#">4</a>
  <a href="#">5</a>
  <a href="#">6</a>
  <a href="#">&raquo;</a>
</div>
                  
              </div>
            </div>


            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Modale</h5>
                <!-- Button trigger modal -->
                <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                  Apri finestra modale
                </button>
                <!-- Modal -->
                <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLiveLabel">Titolo della modale</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">×</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p>Woohoo, stai leggendo questo testo in una modale!</p>
                      </div>
                      <div class="modal-footer">
                        <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-secondary" data-dismiss="modal">Chiudi</button>
                        <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-primary">Salva le modifiche</button>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Tooltip</h5>
              <button class="btn tooltipped" data-position="bottom" data-tooltip="I am a tooltip">Hover me!</button>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Popover</h5>
              <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-secondary" data-container="body" data-toggle="popover" data-placement="top" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." data-original-title="" title="" aria-describedby="popover79365">
                Popover in alto
              </button>
              <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-secondary" data-container="body" data-toggle="popover" data-placement="right" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." data-original-title="" title="" aria-describedby="popover641898">
                Popover a destra
              </button>
              <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-secondary" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." data-original-title="" title="">
                Popover in basso
              </button>
              <button type="button" style="height:50px;" class="waves-effect waves-light btn btn-secondary" data-container="body" data-toggle="popover" data-placement="left" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." data-original-title="" title="">
                Popover a sinistra
              </button>
            </div>
          </div>

          <div class="card-deck">
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Tab</h5>
                <ul class="nav nav-tabs" id="myTab" role="tablist">
                  <li class="nav-item"><a class="nav-link active" id="tab1-tab" data-toggle="tab" href="#tab1" role="tab" aria-controls="tab1" aria-selected="true">Tab 1</a></li>
                  <li class="nav-item"><a class="nav-link" id="tab2-tab" data-toggle="tab" href="#tab2" role="tab" aria-controls="tab2" aria-selected="false">Tab 2</a></li>
                  <li class="nav-item"><a class="nav-link" id="tab3-tab" data-toggle="tab" href="#tab3" role="tab" aria-controls="tab3" aria-selected="false">Tab 3</a></li>
                </ul>
                <div class="tab-content" id="myTabContent">
                  <div class="tab-pane p-3 fade show active" id="tab1" role="tabpanel" aria-labelledby="tab1-tab">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</div>
                  <div class="tab-pane p-3 fade" id="tab2" role="tabpanel" aria-labelledby="tab2-tab">Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </div>
                  <div class="tab-pane p-3 fade" id="tab3" role="tabpanel" aria-labelledby="tab3-tab"> Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</div>
                </div>
              </div>
            </div>
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Tab con icone</h5>
                <ul class="nav nav-tabs" id="myTab2" role="tablist">
                  <li class="nav-item"><a class="nav-link pl-4 pr-4 active" id="tab1a-tab" data-toggle="tab" href="#tab1a" role="tab" aria-controls="tab1a" aria-selected="true"><i class="material-icons">add</i><span class="sr-only"> Tab titolo 1</span></a></li>
                  <li class="nav-item"><a class="nav-link pl-4 pr-4" id="tab2a-tab" data-toggle="tab" href="#tab2a" role="tab" aria-controls="tab2a" aria-selected="false"><i class="material-icons">insert_chart</i><span class="sr-only"> Tab titolo 2</span></a></li>
                  <li class="nav-item"><a class="nav-link pl-4 pr-4" id="tab3a-tab" data-toggle="tab" href="#tab3a" role="tab" aria-controls="tab3a" aria-selected="false"><i class="material-icons">3d_rotation</i><span class="sr-only"> Tab titolo 3</span></a></li>
                </ul>
                <div class="tab-content" id="myTab2Content">
                  <div class="tab-pane p-3 fade show active" id="tab1a" role="tabpanel" aria-labelledby="tab1a-tab"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>
                  <div class="tab-pane p-3 fade" id="tab2a" role="tabpanel" aria-labelledby="tab2a-tab"><p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </p></div>
                  <div class="tab-pane p-3 fade" id="tab3a" role="tabpanel" aria-labelledby="tab3a-tab"><p>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p></div>
                </div>
              </div>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Oggetto media</h5>
              <div class="media">
                <img class="mr-3" data-src="holder.js/64x64" alt="64x64" style="width: 64px; height: 64px;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2264%22%20height%3D%2264%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%2064%2064%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e676a197%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A10pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e676a197%22%3E%3Crect%20width%3D%2264%22%20height%3D%2264%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2212.5%22%20y%3D%2236.8%22%3E64x64%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                <div class="media-body">
                  <h5 class="mt-0">Testata Media</h5>
                  Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                </div>
              </div>
              <div class="media">
                <img class="mr-3" data-src="holder.js/64x64" alt="64x64" style="width: 64px; height: 64px;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2264%22%20height%3D%2264%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%2064%2064%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e676a197%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A10pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e676a197%22%3E%3Crect%20width%3D%2264%22%20height%3D%2264%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2212.5%22%20y%3D%2236.8%22%3E64x64%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                <div class="media-body">
                  <h5 class="mt-0">Testata media</h5>
                  Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.

                  <div class="media mt-3">
                    <a class="pr-3" href="#">
                      <img class="mr-3" data-src="holder.js/64x64" alt="64x64" style="width: 64px; height: 64px;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2264%22%20height%3D%2264%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%2064%2064%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e676a197%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A10pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e676a197%22%3E%3Crect%20width%3D%2264%22%20height%3D%2264%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%2212.5%22%20y%3D%2236.8%22%3E64x64%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                    </a>
                    <div class="media-body">
                      <h5 class="mt-0">Testata media</h5>
                      Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Card</h5>
              <div class="card-columns">
                <div class="card">
                  <img class="card-img-top" data-src="holder.js/100px160/" alt="100%x160" style="height: 160px; width: 100%; display: block;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22374%22%20height%3D%22160%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20374%20160%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e7148675%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A19pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e7148675%22%3E%3Crect%20width%3D%22374%22%20height%3D%22160%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22137.69166564941406%22%20y%3D%2288.7%22%3E374x160%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                  <div class="card-body">
                    <h5 class="card-title">Titolo card molto lunga</h5>
                    <p class="card-text">This is a longer card Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                  </div>
                </div>
                <div class="card p-3">
                  <blockquote class="blockquote mb-0 card-body">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                    <footer class="blockquote-footer">
                      <small class="text-muted">
                        Someone famous in <cite title="Source Title">Source Title</cite>
                      </small>
                    </footer>
                  </blockquote>
                </div>
                <div class="card">
                  <img class="card-img-top" data-src="holder.js/100px160/" alt="100%x160" style="height: 160px; width: 100%; display: block;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22374%22%20height%3D%22160%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20374%20160%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e7148676%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A19pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e7148676%22%3E%3Crect%20width%3D%22374%22%20height%3D%22160%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22137.69166564941406%22%20y%3D%2288.7%22%3E374x160%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                  <div class="card-body">
                    <h5 class="card-title">Titolo card</h5>
                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                    <p class="card-text"><small class="text-muted">Ultimo aggiornamento 3 minuti fa</small></p>
                  </div>
                </div>
                <div class="card bg-primary text-white text-center p-3">
                  <blockquote class="blockquote mb-0">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat.</p>
                    <footer class="blockquote-footer">
                      <small>
                        Someone famous in <cite title="Source Title">Source Title</cite>
                      </small>
                    </footer>
                  </blockquote>
                </div>
                <div class="card text-center">
                  <div class="card-body">
                    <h5 class="card-title">Titolo card</h5>
                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                    <p class="card-text"><small class="text-muted">Ultimo aggiornamento 3 minuti fa</small></p>
                  </div>
                </div>
                <div class="card">
                  <img class="card-img" data-src="holder.js/100px260/" alt="100%x260" style="height: 260px; width: 100%; display: block;" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22374%22%20height%3D%22260%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20374%20260%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161e7148678%20text%20%7B%20fill%3A%23AAAAAA%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A19pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161e7148678%22%3E%3Crect%20width%3D%22374%22%20height%3D%22260%22%20fill%3D%22%23EEEEEE%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22137.69166564941406%22%20y%3D%22138.7%22%3E374x260%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                </div>
                <div class="card p-3 text-right">
                  <blockquote class="blockquote mb-0">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                    <footer class="blockquote-footer">
                      <small class="text-muted">
                        Someone famous in <cite title="Source Title">Source Title</cite>
                      </small>
                    </footer>
                  </blockquote>
                </div>
                <div class="card">
                  <div class="card-body">
                    <h5 class="card-title">Titolo card</h5>
                    <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                    <p class="card-text"><small class="text-muted">Ultimo aggiornamento 3 minuti fa</small></p>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Carousel</h5>
              <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                  <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                  <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                  <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner">
                  <div class="carousel-item active">
                    <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=777&amp;fg=555&amp;text=First slide" alt="First slide [800x400]" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161dd1f7120%20text%20%7B%20fill%3A%23555%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161dd1f7120%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23777%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22274.0250015258789%22%20y%3D%22218.3%22%3EFirst%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                    <div class="carousel-caption d-none d-md-block">
                      <h5>Titolo prima diapositiva</h5>
                      <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
                    </div>
                  </div>
                  <div class="carousel-item">
                    <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=777&amp;fg=555&amp;text=Second slide" alt="Second slide [800x400]" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161dd1f7120%20text%20%7B%20fill%3A%23555%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161dd1f7120%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23777%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22274.0250015258789%22%20y%3D%22218.3%22%3ESecond%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                    <div class="carousel-caption d-none d-md-block">
                      <h5>Titolo seconda diapositiva</h5>
                      <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
                    </div>
                  </div>
                  <div class="carousel-item">
                      <img class="d-block w-100" data-src="holder.js/800x400?auto=yes&amp;bg=777&amp;fg=555&amp;text=Third slide" alt="Third slide [800x400]" src="data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%22800%22%20height%3D%22400%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20800%20400%22%20preserveAspectRatio%3D%22none%22%3E%3Cdefs%3E%3Cstyle%20type%3D%22text%2Fcss%22%3E%23holder_161dd1f7120%20text%20%7B%20fill%3A%23555%3Bfont-weight%3Abold%3Bfont-family%3AArial%2C%20Helvetica%2C%20Open%20Sans%2C%20sans-serif%2C%20monospace%3Bfont-size%3A40pt%20%7D%20%3C%2Fstyle%3E%3C%2Fdefs%3E%3Cg%20id%3D%22holder_161dd1f7120%22%3E%3Crect%20width%3D%22800%22%20height%3D%22400%22%20fill%3D%22%23777%22%3E%3C%2Frect%3E%3Cg%3E%3Ctext%20x%3D%22274.0250015258789%22%20y%3D%22218.3%22%3EThird%20slide%3C%2Ftext%3E%3C%2Fg%3E%3C%2Fg%3E%3C%2Fsvg%3E" data-holder-rendered="true">
                    <div class="carousel-caption d-none d-md-block">
                      <h5>Titolo terza diapositiva</h5>
                      <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
                    </div>
                  </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                  <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                  <span class="sr-only">Precedente</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                  <span class="carousel-control-next-icon" aria-hidden="true"></span>
                  <span class="sr-only">Successivo</span>
                </a>
              </div>
            </div>
          </div>
            
            <div class="carouselM">
    <a class="carouselM-item" href="#one!"><img src="img/1.jpg"></a>
    <a class="carouselM-item" href="#two!"><img src="img/2.jpg"></a>
    <a class="carouselM-item" href="#three!"><img src="img/3.jpg"></a>
    <a class="carouselM-item" href="#four!"><img src="img/4.jpg"></a>
    <a class="carouselM-item" href="#five!"><img src="img/5.jpg"></a>
  </div>

          <div class="card mb-3">
            <div class="card-body">
              <h5 class="card-title border-bottom border-italia">Hero</h5>
              <div class="hero">
                <h1 class="hero-heading display-4">Ciao, mondo!</h1>
                <p class="lead">Questa è una semplice unità hero, un semplice per richiamare un'attenzione particolare al contenuto o alle informazioni in primo piano.</p>
                <hr class="my-4">
                <p>Utilizza le classi di utilità per la tipografia e la spaziatura per l'ingombro del contenuto all'interno del contenitore più grande.</p>
                <p class="lead">
                  <button style="height:50px;" class="waves-effect waves-light btn btn-primary btn-lg" href="#" role="button">Per saperne di più</button>
                </p>
              </div>
            </div>
          </div>

          <div class="card-deck">
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Gruppo elenco</h5>
                <ul class="list-group">
                  <li class="list-group-item">Cras justo odio</li>
                  <li class="list-group-item active">Dapibus ac facilisis in</li>
                  <li class="list-group-item">Morbi leo risus</li>
                  <li class="list-group-item disabled">Porta ac consectetur ac</li>
                  <li class="list-group-item">Vestibulum at eros</li>
                </ul>
              </div>
            </div>
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Gruppo elenco link e bottoni</h5>
                <ul class="list-group">
                  <a href="#" class="list-group-item list-group-item-action active">Cras justo odio</a>
                  <a href="#" class="list-group-item list-group-item-action">Dapibus ac facilisis in</a>
                  <a href="#" class="list-group-item list-group-item-action">Morbi leo risus</a>
                  <button type="button" class="list-group-item list-group-item-action">Porta ac consectetur ac</button>
                  <button type="button" class="list-group-item list-group-item-action" disabled>Vestibulum at eros</button>
                </ul>
              </div>
            </div>

            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Gruppo elenco Flush</h5>
                <ul class="list-group list-group-flush">
                  <li class="list-group-item">Cras justo odio</li>
                  <li class="list-group-item">Dapibus ac facilisis in</li>
                  <li class="list-group-item">Morbi leo risus</li>
                  <li class="list-group-item">Porta ac consectetur ac</li>
                  <li class="list-group-item">Vestibulum at eros</li>
                </ul>
              </div>
            </div>
          </div>


          <div class="card-deck">
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Gruppo elenco con badge</h5>
                <ul class="list-group">
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Cras justo odio
                    <span class="white-text badge badge-primary badge-pill">14</span>
                  </li>
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Dapibus ac facilisis in
                    <span class="white-text badge badge-primary badge-pill">2</span>
                  </li>
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Morbi leo risus
                    <span class="white-text badge badge-primary badge-pill">1</span>
                  </li>
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Cras justo odio
                    <span class="white-text badge badge-primary badge-pill">21</span>
                  </li>
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Dapibus ac facilisis in
                    <span class="white-text badge badge-primary badge-pill">12</span>
                  </li>
                  <li class="list-group-item d-flex justify-content-between align-items-center">
                    Morbi leo risus
                    <span class="white-text badge badge-primary badge-pill">41</span>
                  </li>
                </ul>
              </div>
            </div>
            <div class="card mb-3">
              <div class="card-body">
                <h5 class="card-title border-bottom border-italia">Gruppo elenco custom</h5>
                <div class="list-group">
                  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start active">
                    <div class="d-flex w-100 justify-content-between">
                      <h5 class="mb-1">Intestazione</h5>
                      <small>3 giorni fa</small>
                    </div>
                    <p class="mb-1">Donec id elit non mi porta gravida at eget metus.</p>
                    <small>Donec id elit non mi porta.</small>
                  </a>
                  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
                    <div class="d-flex w-100 justify-content-between">
                      <h5 class="mb-1">Intestazione</h5>
                      <small class="text-muted">3 giorni fa</small>
                    </div>
                    <p class="mb-1">Maecenas sed diam eget risus varius blandit.</p>
                    <small class="text-muted">Donec id elit non mi porta.</small>
                  </a>
                  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
                    <div class="d-flex w-100 justify-content-between">
                      <h5 class="mb-1">Intestazione</h5>
                      <small class="text-muted">3 giorni fa</small>
                    </div>
                    <p class="mb-1">Donec id elit non mi porta gravida at eget metus.</p>
                    <small class="text-muted">Donec id elit non mi porta.</small>
                  </a>
                </div>
              </div>
            </div>

          </div>

        </section>
      </div>


      <a href="GraphicEngine.aspx" aria-hidden="true" data-attribute="back-to-top" class="back-to-top" id="example">
  <i class="white-text small material-icons">arrow_upward</i>
</a>
      
      <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
      <script>          window.__PUBLIC_PATH__ = 'fonts'</script>
      <script src="js/Lorem.js"></script>
      
      <script>
          $(document).ready(function () {
              $('.sidenavM').sidenavM();
          });
      </script>
      
      <script>
          $(document).ready(function () {
              $('.tooltipped').tooltip();
          });
      </script>
      
      <script>
          $(function () {
              $('[data-toggle="popover"]').popover()
          })
      </script>
      
      <script>
          $(document).ready(function () {
              $('.carouselM').carouselM();
          });
      </script>

    </div>
    </form>
</body>
</html>
