// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MyEasyFirstEF.Model;

Console.WriteLine("Hello, World!");

using (var context = new NorthwindDbContext())
{
    // 使用 AsNoTracking 方法查询数据
    var entities = context.SysdataEntities.AsNoTracking().ToList();

    // 处理查询结果
    foreach (var entity in entities)
    {
        Console.WriteLine($"Id: {entity.KeyName}, Name: {entity.SectionName}");
    }
}

