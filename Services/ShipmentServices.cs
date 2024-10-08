using Microsoft.EntityFrameworkCore;
using TechStore_BackEnd.Data;
using TechStore_BackEnd.Models;
using TechStore_BackEnd.Repositories.Interfaces;

namespace TechStore_BackEnd.Services;

public class ShipmentServices : IShipmentRepository
{
    private readonly ApplicationDbContext Context;

    public ShipmentServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<ShipmentDTO>> GetAll()
    {
        try
        {
            var shipmentsAsDTOs = await Context.Shipments.Select(s => new ShipmentDTO
            {
                ShipmentWeightKG = s.Shipment_weight_kg,
                ShipmentPriceUSA = s.Shipment_price_usa,
                ShipmentOrderDate = s.Shipment_order_date,
                ShipmentArrivalDate = s.Shipment_arrival_date,
                CarrierId = s.Carrier_id
            }).ToListAsync();


            return shipmentsAsDTOs;
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<ShipmentDTO?> GetById(int id){

        try
        {
            var shipmentModel = await Context.Shipments.FirstOrDefaultAsync(s=>s.Shipment_id == id);
            var shipmentDTO = new ShipmentDTO{
       
                    ShipmentWeightKG = shipmentModel.Shipment_weight_kg, 
                    ShipmentPriceUSA = shipmentModel.Shipment_price_usa,
                    ShipmentOrderDate = shipmentModel.Shipment_order_date,
                    ShipmentArrivalDate = shipmentModel.Shipment_arrival_date,
                    CarrierId = shipmentModel.Carrier_id
                };
            return shipmentDTO;
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
}
    public async Task<Shipment?> GetById2(int id){

        try
        {
            return await Context.Shipments.FirstOrDefaultAsync(s=>s.Shipment_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task Add(Shipment shipment){
        if (shipment == null)
        {
            throw new ArgumentNullException(nameof(shipment), "el transportador no puede ser nulo");
        }
        else
        {
            try
            {
                await Context.Shipments.AddAsync(shipment);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);
            }
        }
    }

    public async Task Update(Shipment shipment){
        try
        {
            Context.Shipments.Update(shipment);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task Delete(int id){
        try
        {
            var user = await Context.Shipments.FirstOrDefaultAsync(s=>s.Shipment_id == id);
            if(user != null){
                Context.Shipments.Remove(user);
            }
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<bool> CheckExistence(int id){
        return await  Context.Shipments.AnyAsync(s=>s.Shipment_id==id);
    }

}