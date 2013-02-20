var enioEntities = namespace("Enio.CoolJ");

enioEntities.RacunStavka = function (spec) {
    var self = {};

    if (undefined !== spec.ArtiklId) {
        self.ArtiklId = spec.ArtiklId;
    }

    if (undefined !== spec.Cijena) {
        self.Cijena = spec.Cijena;
    }

    if (undefined !== spec.Iznos) {
        self.Iznos = spec.Iznos;
    }

    if (undefined !== spec.Kolicina) {
        self.Kolicina = spec.Kolicina;
    }

    if (undefined !== spec.PdvIznos) {
        self.PdvIznos = spec.PdvIznos;
    }

    if (undefined !== spec.PdvPosto) {
        self.PdvPosto = spec.PdvPosto;
    }

    if (undefined !== spec.Pozicija) {
        self.Pozicija = spec.Pozicija;
    }

    if (undefined !== spec.RacunGlavaId) {
        self.RacunGlavaId = spec.RacunGlavaId;
    }

    if (undefined !== spec.RacunStavkaId) {
        self.RacunStavkaId = spec.RacunStavkaId;
    }

    if (undefined !== spec.TarifaIznos) {
        self.TarifaIznos = spec.TarifaIznos;
    }

    if (undefined !== spec.Artikl) {
        self.Artikl = spec.Artikl;
    }

    if (undefined !== spec.RacunGlava) {
        self.RacunGlava = spec.RacunGlava;
    }

    return self;
}