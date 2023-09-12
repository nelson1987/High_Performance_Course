namespace FreeBank.Domain;

public class Cliente
{
    public required List<Conta> Conta { get; set; }
    public required string Email { get; set; }
}
public class Conta
{
    public required List<Movimentacao> Movimentacao { get; set; }
    public required string Numero { get; set; }
}
public class ContaCorrente : Conta
{

}
public class ContaInvestimento : Conta
{

}
public class Movimentacao
{
    public required Conta Pagador { get; set; }
    public required Conta Recebedor { get; set; }
    public required decimal Valor { get; set; }
    public required DateTime Data { get; set; }

}