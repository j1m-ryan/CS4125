namespace CS4125.Data;

public abstract class Equine : Animal
{
    private EquineBreed _breed;

    public Equine(int id, DateTime dob, Sex sex, EquineBreed _breed) : base(id, dob, sex)
    {
        this._breed = _breed;
    }
}

public enum EquineBreed
{
    ARABIAN,
    APPALOOSA,
    BASHKIR_CURLY,
    BELGIAN_DRAFT,
    BELGIAN_WARMBLOOD,
    BERKSHIRE,
    BRITISH_DRAFT,
    BRITISH_WARMBLOOD,
    BUCKSKIN,
    BURGUNDY,
    BURGUNDY_DRAFT,
    BURGUNDY_WARMBLOOD,
    CHESTNUT,
    CHESTNUT_DRAFT,
    CHESTNUT_WARMBLOOD,
    CLEVELAND_BAY,
    CREMELLO,
    DAPPLE_GREY,
    DUN,
    DUN_DRAFT,
    DUN_WARMBLOOD,
    FRIESIAN,
    GRAY,
    GRAY_DRAFT,
    GRAY_WARMBLOOD,
    GRULLA,
    GRULLA_DRAFT,
    GRULLA_WARMBLOOD,
    HAFLINGER,
    HANOVERIAN,
    HANOVERIAN_DRAFT,
    HANOVERIAN_WARMBLOOD,
    HOLSTEIN,
    HOLSTEIN_DRAFT,
    HOLSTEIN_WARMBLOOD,
    IRISH_DRAFT,
    IRISH_WARMBLOOD,
    ISABELLA,
    ISABELLA_DRAFT,
    ISABELLA_WARMBLOOD,
    ISLAND_PONY,
    JERSEY,
    JERSEY_DRAFT,
    JERSEY_WARMBLOOD,
    KENTUCKY_MORGAN,
    KENTUCKY_WALKER,
    LUSITANO,
    LUSITANO_DRAFT,
    LUSITANO_WARMBLOOD,
    MANGALARGA,
    MANGALARGA_DRAFT,
    MANGALARGA_WARMBLOOD,
    MUSTANG,
    MUSTANG_DRAFT,
    MUSTANG_WARMBLOOD,
    MORGAN,
    MORGAN_DRAFT,
    MORGAN_WARMBLOOD,
    MORGAN_WALKER,
    MORGAN_WALKER_DRAFT,
    MORGAN_WALKER_WARMBLOOD,
    MULBERRY_BAY,
    MULBERRY_BAY_DRAFT,
    MULBERRY_BAY_W
}