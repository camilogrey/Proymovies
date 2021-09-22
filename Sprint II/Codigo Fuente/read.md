@page "/"
@* Shift + Alt + A => Hacer comentarios *@
<div>
    <h1>Movies</h1>
</div>

<div class="row row-cols-1 row-cols-md-3 g-4 mb-3">
    <div class="col">
        <div class="card mb-3 h-100" style="width: 18rem;">
            <img src="/Images/darth.jpg" class="card-img-top" alt="..." width="20" height="200">
            <div class="card-body">
                <h5 class="card-title">@movie1</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>

    </div>
    <div class="col">
        <div class="card mb-3 h-100" style="width: 18rem;">
            <img src="/Images/marvel.jpg" class="card-img-top" alt="..." width="20" height="200">
            <div class="card-body">
                <h5 class="card-title">@movie2</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>
    </div>

    <div class="col">
        <div class="card mb-3 h-100" style="width: 18rem;">
            <img src="/Images/spyderman.jpg" class="card-img-top" alt="..."width="20" height="200">
            <div class="card-body">
                <h5 class="card-title">@movie3</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the
                    card's
                    content.</p>
                <a href="#" class="btn btn-primary">Go somewhere</a>
            </div>
        </div>
    </div>

    
</div>



<div class="mb-3">
    <input class="form-control form-control-sm" type="text" placeholder="Pelicula">
</div>

<div class="mb-3">
    <input class="form-control form-control-sm" type="text" placeholder="Genero">
</div>

<div class="mb-3">
    <input type="file" name="" id="" class="form-control">
</div>

<div>
    <label class="form-label">Pelicula 1 @function_convert_mayusc(movie1)</label>
    <br>
    <label class="form-label">Pelicula 2 @function_convert_minusc(movie2)</label>
</div>

<div>
    <button class="btn btn-info" @onclick="@clic_event_button">Da clic</button>
    <button class="btn btn-danger" @onclick="@clic_event_cancel">Cancelar</button>
</div>
@code{
    public string movie1 = "Star wars";
    public string movie2 = "Avengers";
    public string movie3 = "Spiderman";

    @* Funciones flecha estructura: variable(parametros) => instrucciones; *@
    public string function_convert_mayusc(string value) => value.ToUpper();
    public string function_convert_minusc(string value) => value.ToLower();

    @* Crear métodos *@
    public void clic_event_button(){
        Console.WriteLine("Has dado clic en el botón");
    }
    public void clic_event_cancel(){
        Console.WriteLine("Cancelaste el proceso");
    }
}

