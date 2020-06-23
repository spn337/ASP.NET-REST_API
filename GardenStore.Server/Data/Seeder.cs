using GardenStore.Server.Models;
using System.Linq;

namespace GardenStore.Server.Data
{
    public class Seeder
    {
        public static void SeedData(EFDbContext context)
        {
            #region tblProducts - Товари(Тримери та мотокоси)
            SeedProducts(context, new Product
            {
                Name = "Мотокосa Werk WB-5300S",
                ShortDescription = "Бензинова мотокоса потужністю 4.76к.с.",
                LongDescription = "Бензинова мотокоса потужністю 4.76к.с. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече",
                Price = 1599,
                Count = 4,
                //CategoryId = 11
            });

            SeedProducts(context, new Product
            {
                Name = "Тример Bosch EasyGrassCut 23 ",
                ShortDescription = "Електротример потужністю 0.28 кВт.",
                LongDescription = "Електротример потужністю 0.28 кВт. Має швидкість різання 12500 об/хв",
                Price = 899,
                Count = 4,
                //CategoryId = 11
            });

            SeedProducts(context, new Product
            {
                Name = "Мотокоса Foresta FC-43 2400 Вт",
                ShortDescription = "Бензинова мотокоса потужністю 3.3 к.c.",
                LongDescription = "Бензинова мотокоса потужністю 3.3 к.c. та двотактним двигуном обємом 42.7 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече. Покращений циліндр для ефективного охолодження",
                Price = 2280,
                Count = 4,
                //CategoryId = 11
            });

            SeedProducts(context, new Product
            {
                Name = "Мотокоса Daewoo DABC 520",
                ShortDescription = "Бензинова мотокоса потужністю 3 к.c.",
                LongDescription = "Бензинова мотокоса потужністю 3 к.c. та двотактним двигуном обємом 52 куб см. " +
               "Особливості: Автоматичне регулювання довжини волосіні, ремінь на плече",
                Price = 3995,
                Count = 4,
                //CategoryId = 11
            });

            SeedProducts(context, new Product
            {
                Name = "Мотокоса Werk WB-5300",
                ShortDescription = "Бензинова мотокоса потужністю 4 к.c.",
                LongDescription = "Бензинова мотокоса потужністю 4 к.c. та двотактним двигуном обємом 52 куб см. " +
                "Особливості: Автоматичне регулювання довжини волосіні, регулювання висоти ручки, ремінь на плече.",
                Price = 1499,
                Count = 4,
                //CategoryId = 11
            });
            #endregion

            #region tblProducts - Товари(Газонокосарки)
            SeedProducts(context, new Product
            {
                Name = "Газонокосарка електрична Greenworks GLM1241",
                ShortDescription = "Електрогазонокосарка потужністю 1200Вт та щітковим двигуном",
                LongDescription = "Електрогазонокосарка потужністю 1200Вт та щітковим двигуном. Максимальна швидкість обертання - 3500 об./хв. Об'єм травозбірника - 50л",
                Price = 4499,
                Count = 4,
                //CategoryId = 12
            });

            SeedProducts(context, new Product
            {
                Name = "Газонокосарка AL-KO Classic 3.82 SE",
                ShortDescription = "Електрогазонокосарка потужністю 1400Вт",
                LongDescription = "Електрогазонокосарка потужністю 1200Вт. Ширина захоплення 38см, об'єм травозбірника - 37л.",
                Price = 3199,
                Count = 4,
                //CategoryId = 12
            });

            SeedProducts(context, new Product
            {
                Name = "Газонокосарка Black&Decker BEMW351",
                ShortDescription = "Електрогазонокосарка потужністю 1000Вт",
                LongDescription = "Електрогазонокосарка потужністю 1000Вт. Ширина захоплення 32см, об'єм травозбірника - 35л.",
                Price = 2251,
                Count = 4,
                //CategoryId = 12
            });

            SeedProducts(context, new Product
            {
                Name = "Газонокосарка Bosch Rotak ARM 34 Ergo-Flex",
                ShortDescription = "Електрогазонокосарка потужністю 1300Вт",
                LongDescription = "Електрогазонокосарка потужністю 1300Вт. Ширина захоплення 34см, об'єм травозбірника - 40л. " +
                "Має високообертальний двигун із заниженою передачею, інноваційні напрямні, ручку для перенесення та захист двигуна від перевантаження",
                Price = 4299,
                Count = 4,
                //CategoryId = 12
            });

            SeedProducts(context, new Product
            {
                Name = "Газонокосарка Bosch Rotak 32",
                ShortDescription = "Електрогазонокосарка потужністю 1200Вт",
                LongDescription = "Електрогазонокосарка потужністю 1200Вт. Об'єм травозбірника - 31л. " +
               "Має високообертальний двигун із заниженою передачею, інноваційні напрямні, ручку для перенесення та захист двигуна від перевантаження",
                Price = 2249,
                Count = 4,
                //CategoryId = 12
            });
            #endregion

            #region tblProducts - Товари(Садовий інструмент)
            SeedProducts(context, new Product
            {
                Name = "Секатор площинний Finland",
                ShortDescription = "Секатор сталевий. Діаметр різу до 30мм",
                LongDescription = "Секатор сталевий. Діаметр різу до 30мм. Довжина 20см",
                Price = 296,
                Count = 15,
                //CategoryId = 13
            });

            SeedProducts(context, new Product
            {
                Name = "Сокира-колун Mastertool 2200 г",
                ShortDescription = "Сокира-колун сталева з ручкою зі скловолокна 815 мм",
                LongDescription = "Сокира-колун сталева з ручкою зі скловолокна 815 мм. Довжина 81см. Руків'я з фібергласу з протиковзним гумовим покриттям",
                Price = 445,
                Count = 15,
                //CategoryId = 13
            });

            SeedProducts(context, new Product
            {
                Name = "Секатор My Garden Crazy храповий 20 см",
                ShortDescription = "Секатор сталевий. Довжина 20см",
                LongDescription = "Секатор сталевий. Довжина 20см. Діаметр розрізу: до 30 мм. Дерево: сухі та живі гілки. Лезо: японська сталь + тефлонове покриття",
                Price = 420,
                Count = 15,
                //CategoryId = 13
            });

            SeedProducts(context, new Product
            {
                Name = "Секатор Gruntek Falke",
                ShortDescription = "Секатор сталевий. Довжина 21см",
                LongDescription = "Секатор сталевий. Довжина 21см. Пластикова ручка",
                Price = 167,
                Count = 15,
                //CategoryId = 13
            });

            SeedProducts(context, new Product
            {
                Name = "Гілкоріз Gruntek Luchs 685 мм",
                ShortDescription = "Гілкоріз сталевий з надійними сталевими ручками",
                LongDescription = "Гілкоріз сталевий з надійними сталевими ручками овальної форми та зручними ергономічними захоплювачами. Лезо зі спеціальної сталі SK5, верхнє з покриттям проти налипання.",
                Price = 220,
                Count = 15,
                //CategoryId = 13
            });
            #endregion

            #region tblProducts - Товари(Тачки)
            SeedProducts(context, new Product
            {
                Name = "Тачка садова одноколісна Forte WB6407A",
                ShortDescription = "Тачка садова одноколісна з оцинкованим знімним кузовом",
                LongDescription = "Тачка садова одноколісна з оцинкованим знімним кузовом. Об'єм 65л. Вантажність 120 кг",
                Price = 564,
                Count = 10,
                //CategoryId = 14
            });

            SeedProducts(context, new Product
            {
                Name = "Тачка садова двоколісна Forte WB6211",
                ShortDescription = "Тачка садова одноколісна з оцинкованим кузовом",
                LongDescription = "Тачка садова одноколісна з оцинкованим кузовом. Об'єм 65л. Вантажність 80 кг",
                Price = 846,
                Count = 10,
                //CategoryId = 14
            });

            SeedProducts(context, new Product
            {
                Name = "Тачка будівельна одноколісна Forte WB6414T",
                ShortDescription = "Тачка будівельна одноколісна с підсиленою рамою та оцинкованим знімним кузовом",
                LongDescription = "Тачка будівельна одноколісна с підсиленою рамою та оцинкованим знімним кузовом. Об'єм 90л. Вантажність 160 кг",
                Price = 892,
                Count = 10,
                //CategoryId = 14
            });

            SeedProducts(context, new Product
            {
                Name = "Тачка будівельна двоколісна Budfix WB6404W 200 кг",
                ShortDescription = "Тачка будівельна двоколісна",
                LongDescription = "Тачка будівельна двоколісна. Об'єм 90л. Вантажність 200 кг",
                Price = 1200,
                Count = 10,
                //CategoryId = 14
            });

            SeedProducts(context, new Product
            {
                Name = "Тачка будівельна Truper CAT-60ND",
                ShortDescription = "Тачка будівельна Truper з посиленою пневматичною шиною 100 л",
                LongDescription = "Тачка будівельна Truper з посиленою пневматичною шиною. Об'єм 100л. Вантажність 530 кг",
                Price = 2340,
                Count = 10,
                //CategoryId = 14
            });
            #endregion

            //#region tblCategories - Категорії
            //SeedCategories(context, new Category
            //{
            //    //Id=1
            //    Name = "Кухня",
            //    ParentId = null
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=2
            //    Name = "Посуд",
            //    ParentId = 1
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=3
            //    Name = "Кухонне приладдя",
            //    ParentId = 1
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=4
            //    Name = "Сковороди",
            //    ParentId = 2
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=5
            //    Name = "Кастрюлі",
            //    ParentId = 2
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=6
            //    Name = "Кухонний інвентар",
            //    ParentId = 3
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=7
            //    Name = "Обробні дошки",
            //    ParentId = 3
            //});



            //SeedCategories(context, new Category
            //{
            //    //Id=8
            //    Name = "Сад",
            //    ParentId = null
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=9
            //    Name = "Садова техніка",
            //    ParentId = 8
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=10
            //    Name = "Садовий інвентар",
            //    ParentId = 8
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=11
            //    Name = "Тримери та мотокоси",
            //    ParentId = 9
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=12
            //    Name = "Газонокосарки",
            //    ParentId = 9
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=13
            //    Name = "Садовий інструмент",
            //    ParentId = 10
            //});

            //SeedCategories(context, new Category
            //{
            //    //Id=14
            //    Name = "Тачки",
            //    ParentId = 10
            //});
            //#endregion
        }
        private static void SeedProducts(EFDbContext context, Product model)
        {
            Product product = context.Products.SingleOrDefault(p => p.Name == model.Name);
            if (product == null)
            {
                product = new Product
                {
                    Name = model.Name,
                    ShortDescription = model.ShortDescription,
                    LongDescription = model.LongDescription,
                    Price = model.Price,
                    Count = model.Count,
                    //CategoryId = model.CategoryId
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        //private static void SeedCategories(EFDbContext context, Category model)
        //{
        //    Category category = context.Categories.SingleOrDefault(p => p.Name == model.Name);
        //    if (category == null)
        //    {
        //        category = new Category
        //        {
        //            Name = model.Name,
        //            ParentId = model.ParentId
        //        };
        //        context.Categories.Add(category);
        //        context.SaveChanges();
        //    }
        //}
    }
}
