﻿namespace TodoMinimalApi;

public class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool isComplete { get; set; }
    public string? Secret { get; set; }
}
