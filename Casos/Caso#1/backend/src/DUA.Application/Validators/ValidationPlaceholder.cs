namespace DUA.Application.Validators;

public interface IValidator<in T>
{
    bool IsValid(T instance);
}
