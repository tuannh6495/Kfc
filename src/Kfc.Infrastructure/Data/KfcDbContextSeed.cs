using Kfc.Application.Enities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kfc.Infrastructure.Data
{
    public static class KfcDbContextSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KfcDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<KfcDbContext>>()))
            {
                if (context.MenuTypes.Any())
                {
                    return;
                }

                context.MenuTypes.AddRange(
                    new MenuType
                    {
                        MenuTypeName = "Ưu đãi",
                    },

                    new MenuType
                    {
                        MenuTypeName = "Món mới",
                    },

                    new MenuType
                    {
                        MenuTypeName = "Combo 1 người",
                    },

                    new MenuType
                    {
                        MenuTypeName = "Combo nhóm",
                    }
                );
                context.SaveChanges();

                if (context.Items.Any())
                {
                    return;
                }

                context.Items.AddRange(
                    new Item 
                    {
                        ItemName = "Gà rán",
                        ItemPrice = 30000,
                        MenuTypeId = 1
                    },

                    new Item
                    {
                        ItemName = "Gà quay",
                        ItemPrice = 35000,
                        MenuTypeId = 1
                    }
                );
                context.SaveChanges();

                if (context.Combos.Any())
                {
                    return;
                }

                context.Combos.AddRange(
                    new Combo
                    {
                        ComboName = "Combo 1",
                        ComboDesc = "2 miếng gà",
                        ComboPrice = 50000,
                        MenuTypeId = 2
                    },

                    new Combo
                    {
                        ComboName = "Combo 2",
                        ComboDesc = "3 miếng gà",
                        ComboPrice = 58000,
                        MenuTypeId = 2
                    }
                );
                context.SaveChanges();

                if (context.ComboItems.Any())
                {
                    return;
                }

                context.ComboItems.AddRange(
                    new ComboItem
                    {
                        ComboId = 1,
                        ItemId = 1,
                    },

                    new ComboItem
                    {
                        ComboId = 2,
                        ItemId = 1,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}