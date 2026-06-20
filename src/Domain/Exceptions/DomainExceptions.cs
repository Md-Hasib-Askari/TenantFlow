namespace Domain.Exceptions;

public abstract class DomainException(string message) : Exception(message) { }

// Not Found Exception
public class NotFoundException(string resource) : DomainException($"{resource} was not found.") { }

// Conflict Exception
public class ConflictException(string message) : DomainException(message) { }

// Feature Not Available Exception
public class FeatureNotAvailableException(
    string featureKey,
    string currentPlan,
    string requiredPlan
)
    : DomainException(
        $"Feature {featureKey} requires plan '{requiredPlan}'. Current: '{currentPlan}'"
    )
{
    public string FeatureKey = featureKey;
    public string CurrentPlan = currentPlan;
    public string RequiredPlan = requiredPlan;
}

// Plan Limit Exceed Exception
public class PlanLimitExceedException(string featureKey, int limit, int current)
    : DomainException(
        $"Plan limit exceededd for '{featureKey}'. Limit: {limit}, Current: {current}."
    )
{
    public string FeatureKey = featureKey;
    public int Limit = limit;
    public int Current = current;
}

// Validation Exception
public class ValidationException(Dictionary<string, string[]> errors)
    : DomainException("Validation failed.")
{
    public Dictionary<string, string[]> Errors = errors;
}
