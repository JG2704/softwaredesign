namespace DUA.Application.DTOs;

public sealed record UploadFilesToGenerateDuaRequest(Guid UserId, IReadOnlyCollection<string> FileNames);
public sealed record UploadFilesToGenerateDuaResponse(Guid JobId, string Status);

public sealed record GenerateDuaFromUploadedDocumentsRequest(Guid JobId);
public sealed record GenerateDuaFromUploadedDocumentsResponse(Guid GeneratedDuaId, string Status);

public sealed record SetupDuaTemplateRequest(string Name, string Version);
public sealed record SetupDuaTemplateResponse(Guid TemplateId, bool IsActive);

public sealed record GetDuaHistoryRequest(Guid UserId, int PageNumber = 1, int PageSize = 20);
public sealed record DuaHistoryItemResponse(Guid JobId, string Status, DateTimeOffset RequestedAtUtc);
