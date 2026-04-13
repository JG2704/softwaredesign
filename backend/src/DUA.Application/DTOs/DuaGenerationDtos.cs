namespace DUA.Application.DTOs;

public sealed record UploadFilesToGenerateDuaRequest(Guid UserId, IReadOnlyCollection<string> FileNames);
public sealed record UploadFilesToGenerateDuaResponse(Guid JobId, IReadOnlyCollection<Guid> UploadedDocumentIds);

public sealed record GenerateDuaFromUploadedDocumentsRequest(Guid UserId, Guid JobId, Guid TemplateId);
public sealed record GenerateDuaFromUploadedDocumentsResponse(Guid JobId, string Status);

public sealed record SetupDuaTemplateRequest(string Name, string Version, string Content);
public sealed record SetupDuaTemplateResponse(Guid TemplateId, string Name, string Version);

public sealed record GetDuaHistoryRequest(Guid UserId, int Page, int PageSize);
public sealed record DuaHistoryItemDto(Guid JobId, string Status, DateTimeOffset GeneratedAtUtc);
public sealed record GetDuaHistoryResponse(Guid UserId, IReadOnlyCollection<DuaHistoryItemDto> Items);
